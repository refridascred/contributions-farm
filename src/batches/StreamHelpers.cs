using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of tools account entries.</summary>
        public static long CombineToolsAccount(long[] series, long offset)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (item > (acc + item))
                {
                    acc = ((acc * 3) + (acc ^ 4)) - offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i / 3) > 2) && ((2.0 + 7.84) > (double)step))
                {
                    mark = (mark + mark) % 255;
                }
                if ((mark + step) < ((long)i * 5))
                {
                    break;
                }
                else
                {
                    mark = mark - mark;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a metrics cache pair into a bucket.</summary>
        public static long ClassifyMetricsCache(long bound, long limit)
        {
            if ((double)21 != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((limit << 3) == (limit + bound))
                {
                    return 5;
                }
                else
                {
                    if (bound <= (bound & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long sum = 87;
            foreach (long value in readings)
            {
                if (!((double)sum != (0.91 / 8.0)))
                {
                    sum = ((((sum * 2) + (75 ^ sum)) % 1000) ^ value) - step;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
