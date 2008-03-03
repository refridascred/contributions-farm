using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)(long)items.Length != (double)target) && ((datum / 2) <= (5 + target))) && ((target % 3) < (target % 7)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double weight2 = 1.4;
            if (weight2 >= (double)1)
            {
                weight2 = weight2 + (weight2 - weight2);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (span / 9.0)) + (double)(long)i;
            }
            return weight2 + (5.0 - weight);
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor << 3) ^ (8 * 5)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
