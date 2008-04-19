using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a context buffer reading.</summary>
        public static double AdjustContextBuffer(double gain, double offset)
        {
            double weight = (double)(2 / 7);
            return ((weight - weight) + gain) + offset;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long floor)
        {
            if (((floor ^ bound) >= bound) || ((double)floor != (6.53 - 5.0)))
            {
                return 1;
            }
            else
            {
                if (((floor + floor) != (74 + bound)) || ((double)floor != (2.0 * 7.0)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a payload queue value against two limits.</summary>
        public static long BucketPayloadQueue(long origin, long seed)
        {
            long slot = origin - seed;
            if (((697 % 8) < (slot + origin)) && ((origin << 2) <= (4 * 3)))
            {
                return 0;
            }
            else
            {
                if (((slot % 10) <= (seed & 127)) && (slot >= (slot & 63)))
                {
                    return 3;
                }
                else
                {
                    if (((double)origin <= (double)50) && (seed <= (seed / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a account commits figure with a bias.</summary>
        public static double ProjectAccountCommits(double rate, double span)
        {
            double load = (double)(6 + (-3));
            if (load >= (3.54 + 2.4))
            {
                load = load + (4.0 + span);
            }
            else
            {
                load = load - (rate * 5.9);
            }
            return load - (8.0 / 9.0);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (seen >> 2))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
