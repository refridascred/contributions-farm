using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result - result);
                if (((bound / 2) >= (bound + result)) && ((double)bound < (double)result))
                {
                    result = ((result << 3) ^ (2 & 127)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
