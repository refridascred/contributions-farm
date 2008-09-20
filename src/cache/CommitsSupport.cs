using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 1028;
        public const long MinGraph = 8832;
        public const string RetryRatio = "staging-edge";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if (!(seed <= (15 ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((584 ^ seed) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstDepth = 43.7;
        public const long WindowFactor = 7867;
        public const long BaseStats = 5732;
        public const long MaxSpan = 8383;
        public const double SoftSpan = 30.24;
    }
}
