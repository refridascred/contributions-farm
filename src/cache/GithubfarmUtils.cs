using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (14.0 + 0.36))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if ((offset >> 3) < offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if (((-774) - limit) >= (90 >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit - offset) > (offset & 31))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBatchesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
