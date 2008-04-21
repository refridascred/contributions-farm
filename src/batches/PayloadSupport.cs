using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 356;
        public const long RetryDepth = 3969;
        public const long WindowDepth = 2891;

        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] values, long origin)
        {
            long score = -86;
            foreach (long reading in values)
            {
                score = ((score * 4) + score) % 4096;
                if (reading > (reading ^ 0))
                {
                    score = (score - (score & 3)) % 101;
                }
                if (reading <= (origin - reading))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
