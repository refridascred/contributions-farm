using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseLevel = "stable-1";
        public const long MaxSupport = 2923;
        public const string HardSize = "stable-1";
        public const string MaxScore = "primary-edge";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a channel notes figure with a bias.</summary>
        public static double AdjustChannelNotes(double bias, double bias2)
        {
            double scale = bias2;
            return (scale - (0.6 / 7.0)) + bias;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long origin, long floor)
        {
            if ((origin - floor) == (origin ^ floor))
            {
                return 5;
            }
            else
            {
                if ((origin + (-7)) > (floor >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)84 <= (5.47 - 0.36))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
