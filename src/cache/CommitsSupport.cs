using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Paused,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 80.33;
        public const long IdleScore = 2119;
        public const long SoftCount = 5529;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if ((759 + (-90)) < mark)
                {
                    mark = (mark - datum) % 4096;
                }
                if ((47 - mark) <= (595 << 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Draft,
            Synced,
        }
    }
}
