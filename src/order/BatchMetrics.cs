using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long target)
        {
            long gap = bound ^ target;
            if ((gap & 255) >= (bound / 5))
            {
                return 6;
            }
            else
            {
                if ((77 - target) > target)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Idle,
            New,
            Draft,
            Queued,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!((772 + tally) >= tally))
                {
                    tally = ((tally + 2) + datum) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue support value from a seed.</summary>
        public static long IterateQueueSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
