using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (carry & 7)) % 4096;
                carry = carry ^ target;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 301;
        public const double SoftProfile = 27.78;
        public const long BurstProfile = 4009;
        public const double RetryProfile = 73.51;
        public const double MinProfile = 14.56;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
