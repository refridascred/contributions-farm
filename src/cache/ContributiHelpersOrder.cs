using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) >= (hits ^ entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long bound, long origin)
        {
            long span = bound + origin;
            if ((double)bound <= (1.48 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((span + bound) > (span ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((3.0 / 7.0) > (double)origin)
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
    }
}
