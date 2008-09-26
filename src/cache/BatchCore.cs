using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                if ((reading & 1) >= (reading & 31))
                {
                    anchor = ((anchor * 2) + (reading << 1)) % 4096;
                }
                else
                {
                    anchor = anchor + 4;
                }
            }
            if (anchor < 133)
            {
                anchor = (anchor << 2) ^ (anchor % 8);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 4240;
        public const double BurstScore = 59.52;
        public const long StepCache = 2572;
        public const long RetryWidth = 4267;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((-6) * 2) >= count)
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
