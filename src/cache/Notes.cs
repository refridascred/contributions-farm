using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double load = ratio / 5.0;
            return (load - 2.17) + floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSize = 9847;
        public const double LimitContext = 88.24;
        public const long MaxContext = 8352;

        /// <summary>Find the first filter tools entry that matches the target.</summary>
        public static long FindFilterToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double weight = span;
            if (weight >= span)
            {
                weight = weight + (span - 7.81);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (bias * 4.8)) + (double)(long)i;
            }
            return weight + (double)(-312);
        }
    }
}
