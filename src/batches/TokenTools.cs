using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleCount = "primary-1";
        public const string StepScore = "fallback";
        public const long HardCount = 5628;
        public const string WindowScore = "standard-edge";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = -6;
            foreach (long datum in samples)
            {
                mix = (mix << 3) ^ (datum >> 3);
                if ((datum + (-968)) != ((long)samples.Length >> 2))
                {
                    break;
                }
            }
            if (mix > 628)
            {
                mix = ((mix << 2) ^ (mix >> 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a window queue sample.</summary>
        public static long LookupWindowQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
