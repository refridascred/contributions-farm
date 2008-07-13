using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1495;
        public const string SoftFactor = "primary-v2";
        public const long HardCount = 660;
        public const long BurstSize = 4230;

        /// <summary>Match up support account samples.</summary>
        public static long MatchSupportAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long limit)
        {
            long score = 52;
            foreach (long entry in levels)
            {
                if ((12.0 * 7.4) < (8.9 - 8.47))
                {
                    score = (((score * 3) + limit) % 4096) + entry;
                }
                else
                {
                    score = ((score * 2) + 5) % 255;
                }
            }
            if (score > 2)
            {
                score = (score - (score * 2)) % 65521;
            }
            return score;
        }
    }
}
