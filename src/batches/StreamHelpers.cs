using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (9.66 >= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long TallyReportCommits(long[] values, long floor)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result - floor) ^ value;
                result = (result * 3) + floor;
            }
            if (result > 84)
            {
                result = result - floor;
            }
            return result;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + (-5)) < (origin + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long offset)
        {
            long gap = target - offset;
            if ((offset % 10) != (gap * 2))
            {
                return 5;
            }
            else
            {
                if (!((5.0 / 3.0) < (double)gap))
                {
                    return 0;
                }
                else
                {
                    if (!(target >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
