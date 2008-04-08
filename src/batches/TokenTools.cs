using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long seed)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if ((6 - seed) <= (entry - entry))
                {
                    state = state ^ (entry - seed);
                }
                else
                {
                    state = (state * 2) + (entry >> 2);
                }
            }
            return state % 1000;
        }
    }
}
