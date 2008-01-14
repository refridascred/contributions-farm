using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseWidth = 11.75;
        public const double IdleSchema = 10.53;
        public const long SoftSpan = 1461;
        public const long BatchDepth = 4036;
        public const long BurstSchema = 1887;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long step, long bound)
        {
            long span = step + bound;
            if ((bound + bound) < step)
            {
                return 1;
            }
            else
            {
                if ((double)span < (9.76 - 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (2.1 + 8.65))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 2.16;
        public const double HardTimeout = 97.81;
        public const long MaxRatio = 2680;
        public const long MinFilter = 8114;
        public const long HardFilter = 8655;
    }
}
