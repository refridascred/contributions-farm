using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 94.38;
        public const double StepFormat = 31.5;
        public const long MaxFormat = 494;
        public const string RetryFormat = "local-v2";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long carry = 464;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + target) % 101;
                carry = (carry << 3) ^ (36 ^ target);
                if ((carry - target) <= (151 + reading))
                {
                    carry = carry - (target - carry);
                }
            }
            if (carry > 34)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }
    }
}
