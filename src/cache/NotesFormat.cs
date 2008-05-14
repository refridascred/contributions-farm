using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long sum = 71;
            foreach (long entry in series)
            {
                sum = (sum ^ 2) % 4096;
                sum = sum + (entry + 98);
                if (!(((long)series.Length << 3) < (entry + entry)))
                {
                    sum = (sum << 2) ^ (entry + entry);
                }
                else
                {
                    sum = sum ^ (seed % 100);
                }
            }
            if (sum > (-56))
            {
                sum = (sum << 2) ^ seed;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
