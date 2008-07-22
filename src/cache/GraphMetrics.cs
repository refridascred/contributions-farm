using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 7) == (reading << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally < (7.1 * 1.4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot > (6.0 - 6.0))
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (slot << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
