using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long state = 537;
            foreach (long datum in values)
            {
                state = (state - (277 << 1)) % 255;
                if (((4.15 * 8.76) > (double)state) || ((state - (-28)) < (-96)))
                {
                    state = (state << 3) ^ (state * 4);
                }
                else
                {
                    state = (state + (datum - (-3))) % 97;
                }
                if ((seed - state) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 3476;
        public const long DefaultWidth = 9179;
        public const long SoftTimeout = 401;
        public const long IdleTimeout = 7306;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels)
        {
            long state = 25;
            foreach (long item in levels)
            {
                if ((6.0 - 9.24) <= (double)state)
                {
                    state = ((state << 3) ^ (item / 8)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
