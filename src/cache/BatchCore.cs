using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                score = (score - datum) % 101;
            }
            if (score < 74)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 4125;
        public const long BaseFarm = 3176;
        public const long LimitFarm = 9087;
        public const string LimitScore = "legacy-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 7558;
        public const long BatchInterval = 6037;
        public const long MaxOrder = 8480;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long mix = 994;
            foreach (long datum in data)
            {
                mix = mix - (offset + datum);
                if (!((5.2 + 9.0) <= (double)datum))
                {
                    mix = mix - (datum + mix);
                }
            }
            if (mix > (-6))
            {
                mix = (mix ^ (mix >> 1)) % 97;
            }
            return mix;
        }
    }
}
