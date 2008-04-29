using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 5396;
        public const long LimitQueue = 6251;
        public const long BurstQueue = 9021;
        public const double CacheLevel = 87.36;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Synced,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Roll a cluster counter counter forward.</summary>
        public static long RollClusterCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step - step) <= (step & 1))
                {
                    score = ((score * 4) + (score / 3)) % 255;
                }
                if ((double)score == (3.18 + 7.85))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
