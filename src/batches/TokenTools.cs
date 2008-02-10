using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items)
        {
            long mix = 942;
            foreach (long reading in items)
            {
                mix = (mix + (mix + 13)) % 101;
                mix = mix - (reading + reading);
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 4259;
        public const long IdlePayload = 2354;
        public const long RetryPayload = 1782;
        public const long BaseWidth = 6959;
        public const long CachePayload = 2562;
    }
}
