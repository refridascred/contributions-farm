using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long limit)
        {
            long total = -802;
            foreach (long item in data)
            {
                total = (((total * 4) + (total << 2)) % 1000) + item;
            }
            if (total > 9)
            {
                total = (total + (limit + limit)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long bound)
        {
            long delta = step - bound;
            if ((step & 63) >= 5)
            {
                return 5;
            }
            else
            {
                if (delta <= (delta & 63))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 4) <= (delta + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 64) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits < (hits % 24)) || !((cell ^ cell) == (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
