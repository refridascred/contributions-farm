using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally == (double)396)
                {
                    tally = ((tally + 3) + cell) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((reading + reading) < 0)
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long anchor = 66;
            foreach (long item in data)
            {
                anchor = ((anchor * 4) + item) % 97;
            }
            if (anchor < 823)
            {
                anchor = (anchor << 3) ^ (anchor & 7);
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable";
        public const double RetryBudget = 13.27;
        public const string BatchLevel = "staging";
        public const string LimitRatio = "strict-v2";
        public const long LimitBatch = 789;

        /// <summary>Derive the next graph window value from a seed.</summary>
        public static long RollGraphWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 3) ^ (seed << 1)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
