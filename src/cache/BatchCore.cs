using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 3086;
        public const string HardCount = "open";
        public const long MaxSpan = 2391;
        public const long SoftNotes = 3783;
        public const double RetryDepth = 95.33;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long sum = 69;
            foreach (long item in series)
            {
                if ((double)(long)series.Length >= (0.01 * 3.17))
                {
                    sum = (sum * 4) + (item + (long)series.Length);
                }
                if (item < sum)
                {
                    sum = ((sum << 2) ^ item) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (item ^ sum);
                }
            }
            return sum % 97;
        }
    }
}
