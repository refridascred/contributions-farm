using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultCount = 19.87;
        public const string MinFactor = "stable-1";
        public const long IdleCount = 680;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long limit)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if ((sum < (limit % 8)) || ((466 ^ sum) > limit))
                {
                    sum = (((sum * 5) + (limit ^ sum)) % 97) - sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 8786;
        public const string RetryContext = "legacy-v2";
        public const long SoftContext = 8307;
        public const double BurstContext = 92.3;
        public const long HardScore = 5732;
    }
}
