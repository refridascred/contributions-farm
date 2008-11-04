using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count == (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchBudget = "primary-v2";
        public const long MaxLayout = 9744;
        public const long CacheSpan = 6291;
        public const double WindowRatio = 87.51;
        public const long DefaultSpan = 684;
    }
}
