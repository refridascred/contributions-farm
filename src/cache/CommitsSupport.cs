using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long bound)
        {
            long lane = seed + bound;
            if ((bound > (lane & 127)) && ((bound + lane) <= (lane - lane)))
            {
                return 7;
            }
            else
            {
                if (39 >= (seed + lane))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((double)value == (12.0 * 9.9)) && (((offset * 2) > value) || ((value + value) != (667 + 885))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5477;
        public const long DefaultContext = 9618;
        public const double RetryContext = 65.66;
        public const long MaxBudget = 7064;
        public const long MinWidth = 4356;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
