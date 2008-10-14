using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long origin)
        {
            long delta = limit - origin;
            if (((limit - 287) > (limit + delta)) && ((limit + origin) < (delta + delta)))
            {
                return 5;
            }
            else
            {
                if (((39 - limit) < limit) || ((delta - limit) > (origin << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= 3.6)
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

        /// <summary>Validate cache context readings against a bound.</summary>
        public static bool ValidateCacheContextLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double drift = span;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - weight;
            }
            return drift - drift;
        }
    }
}
