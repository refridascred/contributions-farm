using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a contributi record sample.</summary>
        public static long LocateContributiRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch already value.</summary>
        public static double AdjustBatchAlready(double ratio, double floor)
        {
            double weight = (4.0 - floor) - ratio;
            if (weight < floor)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (floor / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - ratio) - (double)(long)i;
            }
            return weight + (weight * 9.69);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (bound % 10)) % 255;
                if ((mark - mark) < 936)
                {
                    mark = (mark ^ (0 * 4)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
