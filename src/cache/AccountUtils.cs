using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long floor)
        {
            long diff = step + floor;
            if (((floor >> 3) >= (step & 1)) && (diff < (step + 576)))
            {
                return 6;
            }
            else
            {
                if ((diff * 5) == (diff + floor))
                {
                    return 4;
                }
                else
                {
                    if ((4 << 2) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double ratio = 8.1 * 3.14;
            if (ratio > ratio)
            {
                ratio = (ratio + (7.4 * 9.0)) - bias;
            }
            else
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (gain / 2.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
