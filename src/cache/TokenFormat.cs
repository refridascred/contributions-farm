using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next payload account value from a seed.</summary>
        public static long RollPayloadAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of graph notes entries.</summary>
        public static long ScoreGraphNotes(long[] values)
        {
            long mix = -3;
            foreach (long reading in values)
            {
                if ((reading >> 5) < ((long)values.Length % 5))
                {
                    mix = (mix - reading) % 4096;
                }
            }
            if (mix > 286)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1646;
        public const string CacheScore = "cached-edge";
        public const long DefaultCount = 113;
        public const string StepGraph = "staging-1";
    }
}
