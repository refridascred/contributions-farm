using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Ready,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long offset)
        {
            if (4 < (bound ^ 2))
            {
                return 4;
            }
            else
            {
                if (bound < (509 / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.31 * 7.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine cache notes values into a single score.</summary>
        public static long CombineCacheNotes(long[] values)
        {
            long mix = 78;
            foreach (long value in values)
            {
                if (((long)values.Length + mix) > value)
                {
                    mix = ((mix * 4) + mix) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + (mix * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryWidth = 7480;
        public const string SoftRatio = "cached-v2";
        public const long DefaultAlready = 5345;
        public const long WindowAlready = 8550;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            New,
            Queued,
        }
    }
}
