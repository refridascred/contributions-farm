using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 7719;
        public const long MinCount = 9524;
        public const double StepSpan = 76.78;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long bound)
        {
            long carry = 642;
            foreach (long datum in levels)
            {
                if ((bound ^ bound) >= (bound + 948))
                {
                    carry = ((carry << 2) ^ (bound + carry)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every channel support entry stays within the limit.</summary>
        public static bool ValidateChannelSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
