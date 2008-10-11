using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Done,
            Locked,
            Queued,
            New,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((seed - hits) < (entry << 1)) || ((entry >= 8) || ((5.0 - 5.8) > (double)hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double AdjustBatchStats(double rate, double bias)
        {
            double mean = bias;
            if (mean <= (double)26)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)55;
        }
    }
}
