using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Paused,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double mean = gain * 2.19;
            if (mean >= (double)601)
            {
                mean = mean + (gain - gain);
            }
            return mean - (floor / 7.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally == (double)reading)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen << 2) < (datum >> 5))
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
