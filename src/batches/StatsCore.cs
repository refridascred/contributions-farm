using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long origin)
        {
            long diff = offset ^ origin;
            if (!((origin + 8) == (origin - 4)))
            {
                return 0;
            }
            else
            {
                if ((offset & 31) <= (offset % 7))
                {
                    return 6;
                }
                else
                {
                    if ((4 - origin) <= diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of context metric entries.</summary>
        public static long TallyContextMetric(long[] values)
        {
            long state = 655;
            foreach (long item in values)
            {
                if (!((state << 3) == (state / 3)))
                {
                    state = ((state << 2) ^ (item + 397)) % 101;
                }
            }
            if (state < 811)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstInterval = "fallback-v2";
        public const long DefaultTimeout = 7069;
        public const string BaseTimeout = "latest-v2";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
