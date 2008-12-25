using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long bound, long floor)
        {
            if (((floor >> 3) < (882 >> 3)) && (floor <= bound))
            {
                return 7;
            }
            else
            {
                if (!((double)floor < (double)814))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
