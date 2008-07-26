using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long origin)
        {
            if ((378 + 817) > (origin + target))
            {
                return 3;
            }
            else
            {
                if (origin <= (target - 247))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Failed,
            Active,
            Queued,
            Paused,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
