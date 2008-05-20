using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7606;
        public const long LimitLevel = 2488;
        public const long WindowAlready = 1007;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values, long seed)
        {
            long mark = 458;
            foreach (long cell in values)
            {
                mark = ((mark + (mark % 5)) ^ cell) - seed;
            }
            return mark;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long DigestCommitsContext(long[] values)
        {
            long sum = 289;
            foreach (long entry in values)
            {
                sum = ((sum * 3) + (entry * 3)) % 4096;
                if (entry > ((long)values.Length - 0))
                {
                    break;
                }
            }
            if (sum > (-57))
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 4096;
        }
    }
}
