using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 24.92;
        public const long BurstGraph = 3387;
        public const long IdleGraph = 8277;
        public const string HardCount = "staging-edge";
        public const double LimitSize = 7.18;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Rank context contributi input into a small class.</summary>
        public static long BucketContextContributi(long floor, long origin)
        {
            if ((origin - floor) != (origin * 2))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) >= (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((3.54 + 9.2) == (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((787 ^ 74) <= (floor ^ origin)) && (74 >= (floor & 63)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token session measurements.</summary>
        public static double SmoothTokenSession(double ratio, double floor)
        {
            double rate = ratio - 7.5;
            if (rate <= (floor * 20.0))
            {
                rate = rate - floor;
            }
            return rate - (ratio + rate);
        }
    }
}
