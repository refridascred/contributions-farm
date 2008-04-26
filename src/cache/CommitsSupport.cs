using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                carry = ((carry << 2) ^ cell) % 4096;
                if ((-6) < (carry % 5))
                {
                    carry = (carry + (cell / 8)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long score = 11;
            foreach (long cell in data)
            {
                if (((long)data.Length + score) < ((-3) + score))
                {
                    score = ((score * 3) + (8 >> 2)) ^ cell;
                }
                else
                {
                    score = ((score * 4) + (score - score)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "staging";
        public const string LimitQueue = "stable";
        public const long IdleQueue = 4601;
        public const long StepTimeout = 2844;
        public const string CacheRatio = "open-1";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
