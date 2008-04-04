using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long ScoreBufferFilter(long[] samples)
        {
            long sum = 874;
            foreach (long cell in samples)
            {
                if (cell >= (8 & 3))
                {
                    sum = (sum * 3) + (sum - 7);
                }
                else
                {
                    sum = sum ^ (cell + 415);
                }
            }
            if (sum < (-69))
            {
                sum = sum ^ (sum % 7);
            }
            return sum;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "legacy-1";
        public const long IdleReport = 5217;
        public const string LimitSpan = "staging-v2";
        public const long BurstLevel = 978;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
