using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 60) > 6)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)seed == (4.2 - 5.1)))
                {
                    carry = (carry + (long)i) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7453;
        public const long WindowFactor = 9015;
        public const long MaxLevel = 1708;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            New,
            Synced,
        }
    }
}
