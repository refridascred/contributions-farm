using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a profile stream counter forward.</summary>
        public static long RollProfileStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 65521;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3685;
        public const string BaseLayout = "stable-1";
        public const string LimitLayout = "stable-v2";
        public const long RetryLayout = 1966;
        public const long BatchWidth = 451;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
