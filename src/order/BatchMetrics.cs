using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardScore = 1957;
        public const long MinTimeout = 4978;
        public const double BurstRoute = 90.75;
        public const string StepScore = "open-1";

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Pending,
            Ready,
            New,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long step)
        {
            if ((11.0 * 0.32) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((offset % 8) < offset)
                {
                    return 2;
                }
                else
                {
                    if ((step % 16) <= (offset - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) != (1 - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
