using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 7676;
        public const long BaseScore = 715;
        public const double SoftInterval = 32.95;
        public const long BaseTimeout = 1645;
        public const long MaxWidth = 6471;

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools order value from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + (bound + bound)) % 255;
                if ((-964) < (mix + mix))
                {
                    mix = (mix * 4) + bound;
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix * 3) + (mix * 3);
                }
                mix = (mix + (mix << 2)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Ready,
            Retry,
        }
    }
}
