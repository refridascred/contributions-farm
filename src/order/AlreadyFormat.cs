using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long anchor = 340;
            foreach (long item in data)
            {
                anchor = ((((anchor << 2) ^ (anchor + anchor)) % 65521) - item) - offset;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Active,
            Done,
            Pending,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Active,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Digest a series of githubfarm schema entries.</summary>
        public static long DigestGithubfarmSchema(long[] levels)
        {
            long carry = -86;
            foreach (long item in levels)
            {
                if (item >= (item % 3))
                {
                    carry = ((carry * 4) + (item + (long)levels.Length)) % 101;
                }
            }
            return carry;
        }
    }
}
