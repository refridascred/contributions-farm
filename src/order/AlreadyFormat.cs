using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (origin + sum)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double mean = 3.28;
            return ((mean + (mean + mean)) + ratio) + floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 4142;
        public const long WindowContext = 2502;
        public const string SoftFactor = "latest-edge";
        public const string DefaultInterval = "stable";
        public const long SoftRatio = 9480;
    }
}
