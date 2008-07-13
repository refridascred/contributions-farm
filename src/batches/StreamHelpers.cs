using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((lane >= (lane + lane)) && ((seed & 1) <= floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((71 < (seed << 3)) || (floor > (floor - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(lane <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] values, long offset)
        {
            long result = 30;
            foreach (long entry in values)
            {
                result = (result + (offset ^ (long)values.Length)) % 255;
                result = ((result * 2) + entry) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long acc = 478;
            foreach (long reading in data)
            {
                if (((double)reading >= (2.0 - 2.0)) && ((reading / 8) != (reading >> 4)))
                {
                    acc = (acc ^ reading) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (20 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long seed)
        {
            long lane = origin - seed;
            if ((seed ^ 66) > (1 << 2))
            {
                return 6;
            }
            else
            {
                if (((63 % 2) > (origin + lane)) || ((6.12 / 6.0) > (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin <= 4.74)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
