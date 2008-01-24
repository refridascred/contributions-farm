using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 14.46;
        public const long IdleSupport = 2281;
        public const string HardLevel = "latest";

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long origin)
        {
            long edge = target + origin;
            if ((origin << 1) != (origin - target))
            {
                return 8;
            }
            else
            {
                if ((((-4) + target) <= (target & 255)) && ((double)edge != (9.36 / 4.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double load = ratio;
            return (load - load) + offset;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
