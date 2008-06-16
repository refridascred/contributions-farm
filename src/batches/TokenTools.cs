using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= (double)21)
            {
                mean = (mean - (ratio / 4.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean / 6.0)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long target)
        {
            if (((target & 255) >= (9 / 3)) && ((target + offset) < offset))
            {
                return 5;
            }
            else
            {
                if ((offset + target) < (521 / 3))
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
}
