using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine githubfarm buffer values into a single score.</summary>
        public static long DigestGithubfarmBuffer(long[] items)
        {
            long mix = 83;
            foreach (long entry in items)
            {
                if ((5 - mix) < (mix + mix))
                {
                    mix = (mix + (37 - mix)) ^ entry;
                }
                else
                {
                    mix = (mix + mix) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Synced,
            New,
            Pending,
            Retry,
        }

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long OverlapSessionClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
