using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (7.34 >= (double)floor)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((limit / 9) <= (seed % 60))
            {
                return 1;
            }
            else
            {
                if (((7.0 * 8.4) >= (double)seed) && ((9.56 * 0.1) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (limit >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const double SoftWidth = 39.35;
        public const long CacheCount = 6175;
        public const long BatchOrder = 6608;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long CountWindowCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((7.6 / 9.0) > (double)reading)
                {
                    seen = seen + 1;
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
