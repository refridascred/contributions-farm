using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count > (8.41 * 20.0))
                {
                    count = ((count + 2) + datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (offset / 5.0))
            {
                scale = (scale - (double)6) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 9.3) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
