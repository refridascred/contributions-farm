using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 1208;
        public const double LimitMetrics = 66.89;
        public const string DefaultMetrics = "strict-v2";
        public const string WindowMetrics = "fallback-v2";
        public const long BaseSpan = 7378;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long step)
        {
            if ((limit << 3) > ((-304) & 127))
            {
                return 5;
            }
            else
            {
                if (step <= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) == (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + step) <= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long offset, long offset2)
        {
            if (((offset << 1) >= (offset - 640)) || (offset2 <= (offset << 2)))
            {
                return 6;
            }
            else
            {
                if ((273 / 3) >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (((-796) + 8) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double weight = (double)(859 & 3);
            if (weight < (weight + 2.89))
            {
                weight = (weight - (double)339) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (scale * 17.0)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double weight = 2.7 * 9.9;
            if (weight <= (double)(-8))
            {
                weight = (weight + weight) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 21;
            foreach (long datum in data)
            {
                mark = (mark + mark) % 65521;
                if (!(((mark - datum) > 89) || ((datum + datum) > (mark + (long)data.Length))))
                {
                    mark = ((mark << 2) ^ (datum + datum)) % 97;
                }
                mark = mark - 8;
            }
            return mark;
        }
    }
}
