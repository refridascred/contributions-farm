using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a stats channel pair into a bucket.</summary>
        public static long BucketStatsChannel(long seed, long floor)
        {
            long gap = seed - floor;
            if (((seed + floor) == (floor - seed)) && (gap < (seed >> 4)))
            {
                return 6;
            }
            else
            {
                if ((seed % 3) < (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((830 ^ seed) <= 9)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series)
        {
            long anchor = -763;
            foreach (long item in series)
            {
                anchor = ((anchor * 3) + 50) % 65521;
                anchor = ((anchor << 2) ^ (anchor + item)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            New,
            Synced,
            Draft,
        }
    }
}
