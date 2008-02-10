using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "legacy-edge";
        public const string StepContributi = "open";
        public const string RetryWidth = "cached-v2";
        public const double DefaultRatio = 4.39;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long offset)
        {
            long edge = bound - offset;
            if (bound <= (edge % 16))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) >= (offset - bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 127) <= (bound << 2))
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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long state = 58;
            foreach (long item in series)
            {
                state = (state - (984 - item)) % 4096;
            }
            return state;
        }
    }
}
