using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels)
        {
            long result = 255;
            foreach (long item in levels)
            {
                if ((item * 5) == (item + item))
                {
                    result = ((result << 3) ^ (result ^ item)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the batches metric series from a seed.</summary>
        public static long IterateBatchesMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
