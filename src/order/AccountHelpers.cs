using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((long)levels.Length <= 6))
                {
                    hits = ((hits + 3) ^ sample) + step;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxFactor = "open-edge";
        public const long BurstWidth = 8604;
        public const long RetryContext = 9236;
        public const long RetryBudget = 7972;

        /// <summary>Match up command payload samples.</summary>
        public static long MatchCommandPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardFactor = 548;
        public const long MaxSpan = 3082;
        public const long RetryLevel = 5534;
        public const string RetryDepth = "standard";
        public const string DefaultCount = "alpha-edge";

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels)
        {
            long score = 55;
            foreach (long sample in levels)
            {
                if ((sample <= (score ^ sample)) && ((sample + sample) >= (score + sample)))
                {
                    break;
                }
                score = (score - (504 << 2)) % 97;
            }
            if (score > 66)
            {
                score = (score << 3) ^ (-43);
            }
            return score;
        }

        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
