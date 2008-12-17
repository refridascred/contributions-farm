using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "staging-v2";
        public const string IdleInterval = "strict-v2";
        public const long IdleSession = 9896;

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double load = ratio;
            if (load <= 4.65)
            {
                load = (load - (double)421) + offset;
            }
            return load - load;
        }
    }
}
