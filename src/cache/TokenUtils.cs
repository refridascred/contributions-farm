using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long RollToolsQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ (7 ^ (long)i);
                mix = (mix + mix) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long origin)
        {
            if (7 > (origin - offset))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) != (offset & 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
