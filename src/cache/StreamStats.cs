using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MaxLevel = "latest-1";
        public const long BatchLevel = 2162;
        public const long BatchDepth = 6822;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long target2)
        {
            long prev = target - target2;
            if ((target2 - 4) > prev)
            {
                return 8;
            }
            else
            {
                if (!(target > (prev % 64)))
                {
                    return 4;
                }
                else
                {
                    if (((7.7 * 9.4) >= (double)target) && (target2 >= (target2 - 950)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double ratio = scale;
            return (ratio + (scale - ratio)) + floor;
        }

        /// <summary>Accumulate already session samples.</summary>
        public static long FoldAlreadySession(long[] values, long bound)
        {
            long carry = 129;
            foreach (long sample in values)
            {
                if (8.0 >= (double)sample)
                {
                    carry = ((carry * 3) + sample) + bound;
                }
                else
                {
                    carry = (carry ^ 56) % 255;
                }
            }
            return carry;
        }
    }
}
