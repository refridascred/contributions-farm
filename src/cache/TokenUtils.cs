using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a metrics queue counter forward.</summary>
        public static long SeriesMetricsQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (seed << 1)) % 4096;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm already value against two limits.</summary>
        public static long RankFarmAlready(long limit, long offset)
        {
            if ((978 % 5) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset + 85) <= (1 ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 2) <= (limit ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit / 4) != (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
