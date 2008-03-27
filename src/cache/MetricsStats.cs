using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((bound - 413) <= (2 * 2))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (((target + bound) != (39 & 3)) && ((bound << 3) <= (bound - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((19.0 / 7.0) == (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((double)score < (double)seed) && ((8.49 - 5.27) < (double)seed))
                {
                    score = ((score << 2) ^ seed) % 65521;
                    score = (score << 3) ^ (2 << 2);
                }
                if (!((1.57 - 2.1) <= (double)(long)i))
                {
                    score = score + (score - seed);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
