using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long AuditCacheLayoutOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) == (24 - 57))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long TotalBufferMetrics(long[] items)
        {
            long acc = 18;
            foreach (long sample in items)
            {
                long next = (sample ^ acc) % 12;
                if ((6.2 - 4.6) >= (double)next)
                {
                    next = next - (next + 14);
                }
                if (!((acc + sample) > (acc - sample)))
                {
                    acc = (acc + 5) % 255;
                }
            }
            return acc;
        }
    }
}
