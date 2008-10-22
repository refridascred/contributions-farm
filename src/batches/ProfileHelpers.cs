using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long FindNotesEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long seed)
        {
            if (((seed * 5) > seed) || ((seed + seed) > 3))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (7.15 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) < (37 * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (seed >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheScore = 2372;
        public const string BaseRatio = "latest-v2";
        public const string CacheTimeout = "standard-1";
        public const long CacheSize = 9308;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 947;
            foreach (long value in values)
            {
                if (((result / 3) > (result + result)) && ((7.7 * 5.3) <= (double)value))
                {
                    result = (result + (result + 435)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total * 4)) % 1000;
                total = total + total;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = 4.05;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.0 + gain)) - (double)(long)i;
            }
            return scale + offset;
        }
    }
}
