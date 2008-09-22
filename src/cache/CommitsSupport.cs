using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the channel already entries that pass the check.</summary>
        public static long MeasureChannelAlreadyOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + bound) <= (bound + 16))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm checks series from a seed.</summary>
        public static long SeriesGithubfarmChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long floor2)
        {
            if ((floor2 * 4) >= floor)
            {
                return 7;
            }
            else
            {
                if (!(floor <= (floor2 << 3)))
                {
                    return 3;
                }
                else
                {
                    if (floor < 771)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if ((reading - reading) <= (acc >> 2))
                {
                    acc = (acc * 2) + (reading + acc);
                }
                if ((reading & 1) == (26 >> 5))
                {
                    acc = ((acc << 3) ^ (reading % 16)) % 4096;
                }
            }
            if (acc > 3)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
