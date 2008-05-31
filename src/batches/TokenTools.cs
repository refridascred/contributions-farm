using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7883;
        public const long CacheSchema = 5210;
        public const string RetrySchema = "strict-1";
        public const long WindowSchema = 4066;
        public const string BatchSchema = "alpha-edge";

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long MeasureBatchesOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum << 2) < (datum % 24))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
