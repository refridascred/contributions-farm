using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine token metric values into a single score.</summary>
        public static long DigestTokenMetric(long[] data, long target)
        {
            long score = 22;
            foreach (long item in data)
            {
                if (!((score - item) > (669 << 2)))
                {
                    score = score ^ (target * 5);
                }
            }
            if (score > (-617))
            {
                score = (score + (target + 818)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
