using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (reading + reading)) % 4096;
            }
            return acc;
        }
    }
}
