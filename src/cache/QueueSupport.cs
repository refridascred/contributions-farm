using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long MeasureCommandTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((36 + 63) > (tally << 3))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (offset + weight))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 6.0) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Queued,
            Dropped,
            New,
        }
    }
}
