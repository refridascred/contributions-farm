using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples, long target)
        {
            long sum = 91;
            foreach (long sample in samples)
            {
                sum = (((sum + sum) % 65521) - sample) - target;
            }
            return sum;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
