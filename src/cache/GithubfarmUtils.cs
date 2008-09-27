using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5825;
        public const long RetryQueue = 178;
        public const double IdleQueue = 1.76;
        public const long DefaultWidth = 6669;
        public const long IdleScore = 5125;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double bias2 = bias * 1.5;
            if (bias2 <= (double)81)
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 + (double)8;
        }
    }
}
