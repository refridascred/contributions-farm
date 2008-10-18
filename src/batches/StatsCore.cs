using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long offset)
        {
            long span = seed + offset;
            if ((offset - seed) != (span % 64))
            {
                return 0;
            }
            else
            {
                if (!(offset < (538 >> 2)))
                {
                    return 1;
                }
                else
                {
                    if ((41 << 1) > span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the window contributi series from a seed.</summary>
        public static long SeriesWindowContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 3) + ((long)i & 63);
                anchor = ((anchor << 3) ^ anchor) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            New,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 2272;
        public const long HardReport = 1381;
        public const double BatchBudget = 33.67;
        public const double RetryReport = 80.68;
        public const string DefaultReport = "alpha-edge";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
