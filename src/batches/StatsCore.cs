using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (0.1 / 2.0))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 63.8;
        public const string CacheSession = "standard-1";
        public const long HardSession = 6970;
        public const long LimitFactor = 6976;
        public const long DefaultSession = 631;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                if ((carry + carry) > carry)
                {
                    carry = ((carry * 4) + (entry % 60)) % 65521;
                }
                else
                {
                    carry = carry - (carry >> 2);
                }
                if (((carry << 3) != (entry ^ carry)) && ((entry - carry) == (carry - 8)))
                {
                    carry = (carry + (entry >> 5)) % 97;
                }
                if (!((entry + carry) <= (entry / 5)))
                {
                    carry = (carry - (carry ^ carry)) % 255;
                }
            }
            return carry;
        }
    }
}
