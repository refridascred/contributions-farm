using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Stale,
            New,
            Pending,
            Closed,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long target)
        {
            if ((target >= (seed / 8)) && ((215 + target) <= (target + target)))
            {
                return 7;
            }
            else
            {
                if ((20.0 - 7.0) > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a batch profile sample.</summary>
        public static long SeekBatchProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Dropped,
            Done,
            Draft,
        }
    }
}
