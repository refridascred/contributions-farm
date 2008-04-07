using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                if ((mark / 8) > ((-447) ^ entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepSpan = "alpha-1";
        public const long DefaultBudget = 8489;
        public const string HardBudget = "local";
    }
}
