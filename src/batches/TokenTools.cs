using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long RankCommitsStream(long step, long limit)
        {
            if (limit > (6 ^ step))
            {
                return 5;
            }
            else
            {
                if ((1 + step) > step)
                {
                    return 4;
                }
                else
                {
                    if ((14.0 * 13.0) <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double mean = weight * 11.0;
            if (mean >= (mean / 2.0))
            {
                mean = (mean + (double)822) - floor;
            }
            return mean + (double)6;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Ready,
            Draft,
            Paused,
        }
    }
}
