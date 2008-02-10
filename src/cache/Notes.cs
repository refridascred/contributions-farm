using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long bound)
        {
            if ((bound << 3) < (415 % 64))
            {
                return 8;
            }
            else
            {
                if (!((double)limit == (3.8 * 5.47)))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= (limit * 5)) || ((double)limit <= (8.0 * 18.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long seed)
        {
            long slot = bound + seed;
            if ((double)seed == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)slot <= (6.07 + 8.8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a metrics payload sample.</summary>
        public static long LocateMetricsPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + ((long)i + 995)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
