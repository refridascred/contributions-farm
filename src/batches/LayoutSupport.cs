using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if (((floor / 7) != (seed % 64)) && ((2.4 * 6.0) >= 14.0))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= (1.3 + 9.9))
                {
                    return 5;
                }
                else
                {
                    if ((floor + floor) != (630 + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)seed <= (7.0 / 8.0)) && ((double)floor > (17.0 / 5.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 34;
            foreach (long value in items)
            {
                if ((((long)items.Length + 44) < (acc - value)) && ((value << 3) < 916))
                {
                    acc = ((acc * 4) + (value & 31)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (value + value);
                }
                if (((-7) <= (acc & 127)) || ((acc & 15) <= acc))
                {
                    break;
                }
                else
                {
                    acc = acc ^ value;
                }
                acc = (acc + (73 - 37)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total - (value ^ value)) % 4096;
            }
            return total;
        }
    }
}
