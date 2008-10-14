using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 2) ^ (offset * 5);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
