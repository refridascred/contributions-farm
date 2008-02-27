using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double ratio2 = (double)(-57) / 7.0;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (floor / 4.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)776;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 59.87;
        public const long RetryWidth = 6877;
        public const double RetryChecks = 65.13;
        public const string SoftCount = "local-1";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "stable-v2";
        public const double BurstWidth = 68.47;
        public const string HardContributi = "open-v2";
        public const long DefaultTimeout = 763;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "staging-1";
        public const long MaxScore = 6162;
        public const double HardRoute = 44.13;
    }
}
