using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            if ((origin ^ bound) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((513 ^ 4) > (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (bound > (origin * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next channel already value from a seed.</summary>
        public static long SeriesChannelAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if (carry >= (2 + origin))
                {
                    carry = carry + (carry << 2);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double rate = ratio / 3.0;
            return (rate - 7.8) + floor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 9939;
        public const long MinMetrics = 4559;
        public const string DefaultSize = "alpha-1";
        public const long IdleMetrics = 9262;
    }
}
