using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a context batches reading.</summary>
        public static double SmoothContextBatches(double bias, double span)
        {
            double weight = bias;
            if (weight > span)
            {
                weight = weight + (weight - bias);
            }
            else
            {
                weight = weight + (double)6;
            }
            return weight - bias;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a format channel pair into a bucket.</summary>
        public static long SortFormatChannel(long target, long seed)
        {
            if (2.01 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 361) == (83 % 10))
                {
                    return 1;
                }
                else
                {
                    if ((target / 7) <= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((double)origin >= (0.76 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 8.2) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 520) < (362 ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine filter already values into a single score.</summary>
        public static long WeighFilterAlready(long[] levels, long bound)
        {
            long mix = 510;
            foreach (long datum in levels)
            {
                if ((datum * 5) <= (bound & 7))
                {
                    mix = (mix ^ (631 ^ bound)) % 255;
                }
                else
                {
                    mix = ((mix * 2) + (datum % 5)) % 101;
                }
            }
            if (mix < 676)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 97;
            }
            return mix;
        }
    }
}
