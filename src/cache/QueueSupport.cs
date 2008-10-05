using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstLevel = 9911;
        public const long BurstBudget = 5912;
        public const long StepTools = 3214;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) <= (count >> 3))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next already support value from a seed.</summary>
        public static long IterateAlreadySupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
