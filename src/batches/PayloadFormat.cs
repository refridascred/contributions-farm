using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long step)
        {
            long anchor = 183;
            foreach (long value in items)
            {
                if ((value + anchor) <= (anchor << 2))
                {
                    anchor = ((anchor << 3) ^ (503 + step)) % 65521;
                }
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ (anchor & 31)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((545 < (target + target)) || (((double)seen < (double)target) || ((double)cell < (8.2 + 5.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            New,
            Failed,
            Closed,
        }
    }
}
