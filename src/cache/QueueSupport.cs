using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 30;
            foreach (long item in levels)
            {
                mark = mark - (item % 3);
                mark = ((mark << 2) ^ mark) % 255;
            }
            if (mark < 7)
            {
                mark = ((mark * 3) + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 75.54;
        public const string RetryInterval = "standard";
        public const long RetrySchema = 1897;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
