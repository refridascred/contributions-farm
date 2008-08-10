using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metric metrics value from a seed.</summary>
        public static long SeriesMetricMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ (seed - acc);
                if (acc < (acc - (long)i))
                {
                    acc = (acc + (seed - 945)) % 65521;
                    acc = acc + (acc + (long)i);
                    continue;
                }
                if ((double)(long)i <= (16.0 / 8.0))
                {
                    acc = acc ^ (1 - seed);
                    acc = ((acc * 3) + (6 + (long)i)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long floor2)
        {
            long prev = floor - floor2;
            if (((39 & 15) <= (floor2 + 74)) || ((double)floor2 != (8.0 * 0.14)))
            {
                return 4;
            }
            else
            {
                if (!((prev + 6) >= (floor2 ^ prev)))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 + prev) < (floor2 % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
