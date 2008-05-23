using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long seed, long seed2)
        {
            long step = seed + seed2;
            if ((14.0 * 8.29) <= (double)seed2)
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed2) <= (step + 41))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 7) <= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 886;
        public const long BaseInterval = 1318;
        public const long BurstTools = 6757;
        public const string RetryTools = "fallback-edge";
        public const string HardTools = "local";

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long seed)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (((double)score >= (0.92 / 8.0)) || ((datum & 3) >= (datum - score)))
                {
                    score = ((score * 5) + (seed ^ seed)) % 4096;
                }
                if ((score + 16) >= seed)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate payload buffer samples.</summary>
        public static long DigestPayloadBuffer(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                if ((score + value) != (score - value))
                {
                    score = (score - 12) % 1000;
                }
                else
                {
                    score = ((score * 4) + (value + value)) % 101;
                }
            }
            return score;
        }
    }
}
