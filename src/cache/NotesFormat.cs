using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long result = 189;
            foreach (long datum in readings)
            {
                result = (result + (413 - datum)) % 4096;
            }
            if (result < (-871))
            {
                result = ((result * 3) + 690) % 97;
            }
            return result;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
