using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long bound, long origin)
        {
            long next = bound - origin;
            if ((bound / 7) <= ((-6) ^ bound))
            {
                return 5;
            }
            else
            {
                if (((next << 3) < (next >> 4)) || ((next << 3) >= (next ^ next)))
                {
                    return 6;
                }
                else
                {
                    if ((734 + origin) >= (-534))
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

        /// <summary>Measure how many filter cache samples are out of range.</summary>
        public static long TallyFilterCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) >= (sample / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double scale = gain;
            return scale + (bias * 9.6);
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (!(bound >= (bound / 9)))
            {
                return 5;
            }
            else
            {
                if ((double)floor > 3.22)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound2 < (8.1 * 15.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate format buffer samples.</summary>
        public static long ScoreFormatBuffer(long[] values)
        {
            long acc = 5;
            foreach (long entry in values)
            {
                if ((acc * 5) > (entry + entry))
                {
                    acc = ((acc << 3) ^ ((-17) + entry)) % 1000;
                    acc = acc + (entry >> 3);
                }
                else
                {
                    acc = (acc << 2) ^ (acc / 9);
                    acc = (acc + (long)values.Length) % 255;
                }
                acc = (acc ^ (entry + entry)) % 97;
                if ((acc / 7) >= acc)
                {
                    acc = (acc + acc) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + (-938))) % 1000;
                }
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ ((long)values.Length + acc);
            }
            return acc % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryTimeout = "fallback-v2";
        public const long RetryCommand = 909;
        public const long BurstCommand = 683;
    }
}
