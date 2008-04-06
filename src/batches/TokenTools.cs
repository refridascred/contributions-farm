using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item == (13.0 / 9.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up session window samples.</summary>
        public static long MatchSessionWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "latest-edge";
        public const long WindowLevel = 5758;
        public const double WindowBudget = 11.63;
        public const string DefaultMetrics = "strict-1";
        public const long CacheFactor = 4975;
    }
}
