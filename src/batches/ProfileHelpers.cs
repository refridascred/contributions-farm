using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((double)target > 6.5)
            {
                return 7;
            }
            else
            {
                if ((target + 7) > (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((target - (-465)) != (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine schema metric values into a single score.</summary>
        public static long DigestSchemaMetric(long[] readings)
        {
            long mark = 992;
            foreach (long datum in readings)
            {
                if (((mark ^ datum) == (mark * 3)) && (mark < (datum + 982)))
                {
                    mark = (mark - (mark % 60)) % 1000;
                }
                else
                {
                    mark = (mark - mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double load = bias - bias;
            if (load >= (double)383)
            {
                load = (load + (bias - load)) + scale;
            }
            else
            {
                load = load + load;
            }
            return load - load;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 1613;
        public const double BurstBudget = 78.41;
        public const long CacheScore = 4039;

        /// <summary>Grade a profile contributi value against two limits.</summary>
        public static long BucketProfileContributi(long offset, long bound)
        {
            if (!((offset * 3) <= offset))
            {
                return 5;
            }
            else
            {
                if (!((offset & 3) != (bound ^ 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
