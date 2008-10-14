using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

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
