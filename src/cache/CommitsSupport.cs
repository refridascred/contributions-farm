using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values, long limit)
        {
            long result = 93;
            foreach (long datum in values)
            {
                result = (result + (limit ^ result)) % 255;
                if ((double)limit <= 16.0)
                {
                    result = ((result * 3) + (datum * 2)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long seed)
        {
            if ((floor & 7) < (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) == (seed >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) >= (5 << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
