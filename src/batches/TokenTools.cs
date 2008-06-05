using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 829;
        public const long HardFactor = 6054;
        public const string IdleWindow = "local-edge";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= 5) || ((matches + matches) > (54 - 27)))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }
    }
}
