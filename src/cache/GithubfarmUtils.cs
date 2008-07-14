using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two window token measurements.</summary>
        public static double AdjustWindowToken(double gain, double bias)
        {
            double bias2 = (double)(286 + 3);
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - 18.0;
            }
            else
            {
                bias2 = bias2 + (gain + 16.0);
            }
            return bias2 - (double)9;
        }
    }
}
