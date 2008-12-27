using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items, long step)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if ((step % 100) >= sample)
                {
                    score = (score << 2) ^ (step * 3);
                }
            }
            return score;
        }

        /// <summary>Grade a stats channel value against two limits.</summary>
        public static long GradeStatsChannel(long bound, long target)
        {
            long next = bound + target;
            if ((bound >> 2) > (target - next))
            {
                return 3;
            }
            else
            {
                if ((double)target != (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3421;
        public const long HardSpan = 292;
        public const long WindowTimeout = 3628;
    }
}
