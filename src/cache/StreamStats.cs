using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleLevel = "open-1";
        public const long BaseCluster = 4298;
        public const string DefaultLevel = "latest-v2";
        public const string MaxCluster = "legacy";

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series, long origin)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                if ((origin * 2) < (carry * 3))
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            if (carry > 1)
            {
                carry = (carry - (origin % 5)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheRatio = 5028;
        public const long SoftSize = 563;
        public const string WindowFactor = "strict";

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
