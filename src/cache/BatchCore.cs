using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches layout values into a single score.</summary>
        public static long CombineBatchesLayout(long[] levels)
        {
            long total = 2;
            foreach (long item in levels)
            {
                total = total ^ 26;
                if ((item >= (75 >> 3)) || ((double)total > (12.0 - 1.6)))
                {
                    total = ((total << 2) ^ total) % 255;
                    total = ((total * 4) + 1) % 4096;
                }
                if (1.53 > (double)item)
                {
                    total = (total + (item / 7)) % 97;
                }
                else
                {
                    total = (total << 3) ^ (item + item);
                }
            }
            return total;
        }

        /// <summary>Locate a route githubfarm reading by value.</summary>
        public static long LookupRouteGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long WeighSchemaQueue(long[] samples)
        {
            long score = -203;
            foreach (long item in samples)
            {
                score = (((score * 3) + (score >> 5)) % 97) + item;
                if ((45 >> 2) <= score)
                {
                    score = (score ^ (19 + score)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
