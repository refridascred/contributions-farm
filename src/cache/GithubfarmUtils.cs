using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already order figure with a bias.</summary>
        public static double ProjectAlreadyOrder(double bias, double bias2)
        {
            double bias3 = 5.1;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias + bias)) - (double)(long)i) - bias2;
            }
            return bias3 - (double)2;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            long gap = bound - seed;
            if ((double)gap <= (double)125)
            {
                return 3;
            }
            else
            {
                if (bound > 27)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
