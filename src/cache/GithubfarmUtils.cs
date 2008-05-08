using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long origin)
        {
            long diff = seed - origin;
            if ((seed + origin) != (diff * 4))
            {
                return 1;
            }
            else
            {
                if ((7.0 / 4.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((seed << 2) > (seed % 24)) || ((double)origin > (1.53 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin > (diff % 64))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data, long target)
        {
            long score = 753;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    long step = cell;
                    score = (((score + (685 - step)) % 255) ^ (long)i) - target;
                }
                score = (score + (score - score)) % 255;
            }
            if (score < 570)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks metrics readings.</summary>
        public static long MatchChecksMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
