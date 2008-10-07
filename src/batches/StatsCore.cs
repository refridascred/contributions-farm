using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long state = 26;
            foreach (long sample in values)
            {
                if ((389 + state) != (796 - seed))
                {
                    state = (state ^ state) % 101;
                }
                if (seed > (state ^ sample))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = state - (state & 15);
            }
            return state;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if ((double)anchor <= (7.35 * 16.0))
                {
                    anchor = anchor + (anchor ^ anchor);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
