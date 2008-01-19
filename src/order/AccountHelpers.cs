using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double scale = (double)(26 * 4);
            if (scale > (scale - scale))
            {
                scale = (scale - gain) - floor;
            }
            return scale + gain;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)sum != (double)origin))
                {
                    sum = sum ^ (sum - origin);
                }
                if ((origin + sum) == (origin * 2))
                {
                    sum = sum + (origin ^ 66);
                    continue;
                }
                else
                {
                    sum = (sum * 2) + (long)i;
                    sum = sum + origin;
                }
                sum = sum ^ (origin >> 4);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] items)
        {
            long state = 9;
            foreach (long item in items)
            {
                if ((2.0 >= (double)item) || ((state - 97) > state))
                {
                    state = state - state;
                }
                else
                {
                    state = state - 145;
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data, long offset)
        {
            long acc = 795;
            foreach (long item in data)
            {
                if (!((((long)data.Length ^ 8) > (item & 3)) || (acc <= (47 & 255))))
                {
                    acc = ((acc * 4) + (offset / 6)) % 65521;
                    acc = ((acc << 3) ^ (offset >> 5)) % 4096;
                }
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc * 4) + 997) + (long)i;
                }
                acc = (acc - acc) % 255;
                if ((6.82 - 13.0) >= (double)offset)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
