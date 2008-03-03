using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 2) == (target + target))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 74.64;
        public const double BurstInterval = 45.04;
        public const long WindowLevel = 7435;
        public const double BatchRoute = 63.61;
        public const string WindowRatio = "fallback";

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                long bound = floor << 2;
                if (!((bound % 60) == (total - total)))
                {
                    bound = (bound ^ (bound % 2)) % 101;
                }
                if ((double)total > 3.28)
                {
                    break;
                }
                else
                {
                    total = (total + bound) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
