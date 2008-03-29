using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9056;
        public const long SoftSize = 4442;
        public const long LimitSpan = 2658;
        public const long BaseSchema = 4031;
        public const long LimitRatio = 4400;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long floor)
        {
            long acc = 13;
            foreach (long entry in levels)
            {
                if ((2.5 + 6.1) >= (20.0 - 13.0))
                {
                    acc = (((acc << 3) ^ (acc + floor)) % 97) - entry;
                }
            }
            if (acc < 5)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
