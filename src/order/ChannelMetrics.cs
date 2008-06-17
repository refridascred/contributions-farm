using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entry entries.</summary>
        public static long DigestSessionEntry(long[] levels)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ (reading ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1319;
        public const long RetryFilter = 5167;
        public const long StepFilter = 9739;
    }
}
