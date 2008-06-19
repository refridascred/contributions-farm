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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((5 - (-39)) >= hits) && ((93 <= (hits + 9)) || ((hits + hits) > hits)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
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
