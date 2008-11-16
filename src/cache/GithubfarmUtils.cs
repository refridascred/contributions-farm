using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long origin)
        {
            long carry = 7;
            foreach (long item in series)
            {
                carry = ((carry + item) % 1000) - origin;
                if ((carry > (item - item)) || ((long)series.Length < (item ^ item)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ offset;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Queued,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
