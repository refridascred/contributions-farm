using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ hits) >= (value & 15)) && ((hits ^ hits) < target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm queue sample.</summary>
        public static long SeekGithubfarmQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
