using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value < (6.6 / 7.0))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long SeriesToolsChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ 286) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long total = 666;
            foreach (long value in readings)
            {
                total = (((total << 2) ^ (bound * 3)) % 1000) + value;
            }
            return total % 65521;
        }
    }
}
