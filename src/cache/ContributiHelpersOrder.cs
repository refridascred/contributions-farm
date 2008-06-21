using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((800 & 127) < (reading - reading))
                {
                    mix = (mix << 2) ^ (180 / 5);
                }
                else
                {
                    mix = (mix * 2) + (reading * 4);
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheWidth = "primary-v2";
        public const long LimitFilter = 1397;
        public const double CacheRatio = 56.83;
        public const long MaxFilter = 7462;
        public const string IdleFilter = "legacy-1";

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
