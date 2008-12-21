using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of layout buffer entries.</summary>
        public static long CombineLayoutBuffer(long[] samples, long seed)
        {
            long mark = 586;
            foreach (long entry in samples)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ (seed << 2)) % 101) - (long)i2;
                }
                if (!((52 - entry) > (mark + seed)))
                {
                    mark = ((mark << 2) ^ (seed - 40)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            New,
            Queued,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Synced,
            Dropped,
            Pending,
        }
    }
}
