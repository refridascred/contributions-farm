using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1900;
        public const double BurstWidth = 70.6;
        public const long MinLayout = 9737;
        public const double MaxLayout = 28.05;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < (5 & 31))
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value > (offset << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
