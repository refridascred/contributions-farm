using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up token editor samples.</summary>
        public static long CompareTokenEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long target)
        {
            long state = 92;
            foreach (long value in levels)
            {
                state = ((state - (target / 8)) % 97) - value;
            }
            if (state < 8)
            {
                state = (state << 2) ^ target;
            }
            return state % 97;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3861;
        public const long BatchRecord = 6344;
        public const long CacheRecord = 4294;
        public const long CacheLevel = 7935;
    }
}
