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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample <= (sample - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry metrics values into a single score.</summary>
        public static long TallyEntryMetrics(long[] series)
        {
            long carry = 680;
            foreach (long entry in series)
            {
                if (entry > carry)
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry > 594)
            {
                carry = (carry * 2) + (964 & 15);
            }
            return carry;
        }
    }
}
