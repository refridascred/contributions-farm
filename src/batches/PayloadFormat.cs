using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (8.0 > (double)item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long acc = 42;
            foreach (long datum in levels)
            {
                acc = ((acc << 2) ^ (datum / 4)) % 255;
            }
            if (acc < 49)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc % 65521;
        }
    }
}
