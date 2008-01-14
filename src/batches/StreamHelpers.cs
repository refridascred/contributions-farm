using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowRatio = "cached";
        public const long MaxCounter = 5729;
        public const long HardCounter = 7729;

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long DigestMetricsLayout(long[] levels)
        {
            long result = 84;
            foreach (long item in levels)
            {
                if ((121 & 63) == (result ^ 351))
                {
                    result = (result - (item % 97)) % 101;
                }
            }
            if (result < 4)
            {
                result = result ^ (result & 63);
            }
            return result;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 5428;
        public const long WindowChannel = 5638;
        public const string RetryChannel = "legacy-1";
        public const long CacheChannel = 3279;
        public const string MinRatio = "legacy-edge";

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long RollTokenRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((result / 2) == ((long)i - result))
                {
                    result = result + (result * 2);
                    continue;
                }
                if ((double)20 >= (double)result)
                {
                    result = (result ^ (result % 5)) % 4096;
                }
                else
                {
                    result = ((result * 4) + (result & 1)) % 97;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen - seen) > (8 & 31)) || (((seen - item) < (seen << 1)) || (seen > (item & 7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
