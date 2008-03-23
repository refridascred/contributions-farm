using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long offset)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                if ((offset < (offset % 100)) || ((0 / 4) >= offset))
                {
                    carry = carry ^ (reading / 4);
                }
            }
            if (carry > 690)
            {
                carry = (carry ^ (2 >> 4)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftScore = 4.29;
        public const long WindowEditor = 8129;
        public const long MinEditor = 5722;
    }
}
