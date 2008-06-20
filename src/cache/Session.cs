using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 5811;
        public const long BaseDepth = 9346;
        public const long IdleSpan = 7113;
        public const string BatchTimeout = "strict-1";

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            long slot = bound ^ floor;
            if (!((double)floor > (double)slot))
            {
                return 4;
            }
            else
            {
                if (!(514 >= slot))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 / 5.0) == (double)floor) && ((double)floor <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + floor) == (slot & 15))
                        {
                            return 2;
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
}
