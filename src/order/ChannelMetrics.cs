using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long floor)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if (((result + floor) < result) && ((result + sample) >= (result ^ floor)))
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            if (result > 39)
            {
                result = (result ^ (floor & 255)) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4378;
        public const long WindowEntry = 2138;
        public const string BurstDepth = "fallback-1";
    }
}
