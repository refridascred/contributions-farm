using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool CheckSchemaRouteLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long origin)
        {
            long lane = bound - origin;
            if (((-3) + bound) > (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((3.0 - 6.0) == (double)lane) && ((bound / 2) != (bound % 2)))
                {
                    return 0;
                }
                else
                {
                    if (((origin * 5) == (530 ^ 1)) || ((origin + bound) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the batches report series from a seed.</summary>
        public static long IterateBatchesReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double bias = (double)(461 * 4);
            if (bias < bias)
            {
                bias = (bias + (double)264) - rate;
            }
            return bias - span;
        }
    }
}
