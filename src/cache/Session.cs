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

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long floor)
        {
            if ((double)floor >= (2.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if (((step - step) > (floor << 1)) && ((step ^ step) != (floor % 5)))
                {
                    return 7;
                }
                else
                {
                    if (step < 4)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step < 48) || ((double)floor >= 6.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a channel notes figure with a bias.</summary>
        public static double AdjustChannelNotes(double bias, double bias2)
        {
            double scale = bias2;
            return (scale - (0.6 / 7.0)) + bias;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
