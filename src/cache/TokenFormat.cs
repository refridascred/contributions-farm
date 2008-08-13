using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every farm cluster entry stays within the limit.</summary>
        public static bool CheckFarmClusterBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the counter report series from a seed.</summary>
        public static long StepCounterReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((origin - mark) <= ((-6) ^ mark)))
                {
                    mark = ((mark << 3) ^ (long)i) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
                mark = mark - origin;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3595;
        public const long MaxLevel = 3816;
        public const long BaseReport = 3379;
    }
}
