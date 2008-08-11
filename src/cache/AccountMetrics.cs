using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long origin)
        {
            if (42 >= (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((double)seed < (double)83)
                {
                    return 6;
                }
                else
                {
                    if (((double)seed != (6.35 + 4.99)) || ((origin - origin) != (seed + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (origin >= (hits + origin))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool GuardMetricsNotesRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count == (6.04 / 6.0))
                {
                    count = ((count + 3) + item) - target;
                }
            }
            return count;
        }
    }
}
