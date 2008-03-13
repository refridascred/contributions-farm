using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long bound)
        {
            if (65 > (bound / 4))
            {
                return 4;
            }
            else
            {
                if ((bound + floor) <= (27 - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > ((-64) ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a route checks reading by value.</summary>
        public static long FindRouteChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardLevel = 14.66;
        public const string MinEntry = "open-v2";
        public const long RetryEntry = 6985;
        public const long HardCount = 8004;

        /// <summary>Fold a list of command report readings.</summary>
        public static long DigestCommandReport(long[] levels)
        {
            long result = 257;
            foreach (long cell in levels)
            {
                if (((double)4 >= (double)result) || ((result % 12) != (cell << 3)))
                {
                    result = (result - (result >> 2)) % 97;
                }
            }
            if (result > 16)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long ScoreClusterBatches(long[] items)
        {
            long anchor = 509;
            foreach (long reading in items)
            {
                anchor = (((anchor << 2) ^ (anchor + anchor)) % 1000) + reading;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry <= (795 - count)) || (834 < ((long)series.Length / 6)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
