using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7409;
        public const long LimitDepth = 3735;
        public const string HardScore = "legacy-v2";

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a cache metric reading by value.</summary>
        public static long SeekCacheMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format record input into a small class.</summary>
        public static long RankFormatRecord(long floor, long limit)
        {
            if (((708 << 1) < floor) && ((double)limit != (9.0 - 3.0)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 3) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
