using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Locked,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double gain2 = (14.0 / 6.0) + 19.0;
            if (gain2 > (gain + gain))
            {
                gain2 = (gain2 - gain2) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - 9.4) + (double)(long)i;
            }
            return gain2 - 3.62;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first command session entry that matches the target.</summary>
        public static long LookupCommandSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
