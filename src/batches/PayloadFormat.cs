using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long StepCounterFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                long edge = 8 / 2;
                if ((limit + edge) == (acc ^ 880))
                {
                    acc = (acc - (acc & 63)) % 4096;
                }
                else
                {
                    edge = edge - limit;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    edge = (edge ^ (acc + (long)i2)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool CheckMetricsPayloadRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long total = 83;
            foreach (long value in values)
            {
                if (((total / 5) < (value + seed)) || (total < (90 + seed)))
                {
                    total = (total + (12 + total)) % 101;
                }
            }
            if (total < 3)
            {
                total = (total << 2) ^ (seed - 480);
            }
            return total % 97;
        }
    }
}
