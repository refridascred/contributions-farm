using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a commits contributi value against two limits.</summary>
        public static long RankCommitsContributi(long target, long limit)
        {
            if ((double)limit >= (19.0 - 2.5))
            {
                return 7;
            }
            else
            {
                if (target >= (limit + target))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
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
