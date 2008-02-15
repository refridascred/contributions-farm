using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double drift = rate;
            if (drift >= (double)(-3))
            {
                drift = (drift + rate) + span;
            }
            return drift - drift;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (74 > tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long mark = 370;
            foreach (long datum in readings)
            {
                mark = (mark + (datum + mark)) % 255;
            }
            if (mark < 8)
            {
                mark = ((mark * 4) + (mark + limit)) % 101;
            }
            return mark;
        }
    }
}
