using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if (target > (7 - total))
                {
                    total = total - target;
                }
                else
                {
                    total = total ^ ((long)i / 6);
                }
                total = (total * 2) + (total + 199);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((double)839 < (double)cur)
            {
                return 5;
            }
            else
            {
                if (((181 << 3) != (cur * 5)) && (cur < offset))
                {
                    return 1;
                }
                else
                {
                    if ((953 >> 5) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 9931;
        public const string BatchTimeout = "latest-v2";
        public const long BurstToken = 709;
        public const long StepToken = 6758;
        public const long CacheToken = 3694;
    }
}
