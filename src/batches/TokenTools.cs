using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "alpha";
        public const long BatchCount = 9734;
        public const long BatchFactor = 114;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long seed)
        {
            long anchor = 23;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ (datum % 60)) + seed;
            }
            return anchor % 4096;
        }
    }
}
