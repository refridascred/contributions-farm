using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mark = 0;
            foreach (long reading in items)
            {
                if (((double)mark <= 4.0) || ((double)reading > (3.37 + 1.08)))
                {
                    mark = mark + reading;
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = (mark * 5) + (mark >> 1);
            }
            return mark % 4096;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound % 100) != (1 - (long)i))
                {
                    total = ((total << 2) ^ ((long)i + 365)) % 101;
                }
                if ((double)total < (double)bound)
                {
                    total = (total + ((long)i / 9)) % 65521;
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 1743;
        public const long DefaultCount = 9847;
        public const double BatchRoute = 23.31;
        public const double BaseRoute = 8.57;
    }
}
