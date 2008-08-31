using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 9040;
        public const string BurstFactor = "open-edge";
        public const long CacheBatch = 4888;
        public const string StepTimeout = "staging";
        public const string RetryBatch = "fallback-1";

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long CompareChannelAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                if ((438 & 7) != ((long)values.Length % 97))
                {
                    mix = mix ^ reading;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 4) + (mix / 3);
            }
            return mix % 65521;
        }
    }
}
