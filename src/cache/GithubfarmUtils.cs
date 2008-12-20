using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next filter commits value.</summary>
        public static double ProjectFilterCommits(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - 2.65) + (double)(long)i) - offset;
            }
            return gain + (gain * 7.5);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum * 2) != (bound ^ 232))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = total - (total + total);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
