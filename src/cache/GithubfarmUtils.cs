using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine farm batch values into a single score.</summary>
        public static long FoldFarmBatch(long[] data)
        {
            long carry = 75;
            foreach (long datum in data)
            {
                if ((double)carry < (6.1 - 13.0))
                {
                    carry = (carry - (carry + datum)) % 255;
                }
            }
            if (carry > 34)
            {
                carry = (carry * 5) + (carry - 52);
            }
            return carry % 1000;
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long CountClusterCounterOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < limit)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Locked,
            Ready,
            Dropped,
            Pending,
        }
    }
}
