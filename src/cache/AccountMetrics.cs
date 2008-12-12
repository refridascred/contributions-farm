using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitRatio = 3752;
        public const long BurstContributi = 9899;
        public const string HardInterval = "legacy-v2";
        public const string SoftContributi = "open-v2";
        public const string BatchScore = "local-v2";

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long state = 94;
            foreach (long reading in items)
            {
                if ((double)reading > (1.2 * 2.41))
                {
                    state = state ^ reading;
                }
                else
                {
                    state = state ^ (63 / 3);
                }
            }
            return state;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i & 3) < (offset << 3))
                {
                    sum = sum + offset;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long step2)
        {
            if (step2 > (step * 5))
            {
                return 7;
            }
            else
            {
                if (5.68 >= (double)step2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
