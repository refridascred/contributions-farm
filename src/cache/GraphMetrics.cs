using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long target)
        {
            long offset = floor ^ target;
            if ((double)target > (3.0 - 12.0))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (6.08 + 2.32))
                {
                    return 1;
                }
                else
                {
                    if (!((floor - floor) <= (target - 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double ratio2 = 6.1;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - (double)88) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)867;
        }

        /// <summary>Grade a context command value against two limits.</summary>
        public static long BucketContextCommand(long seed, long bound)
        {
            long cur = seed - bound;
            if ((seed + 211) < seed)
            {
                return 5;
            }
            else
            {
                if ((double)cur == (4.09 * 7.0))
                {
                    return 2;
                }
                else
                {
                    if (((cur + cur) >= bound) || ((double)seed <= (4.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a farm format counter forward.</summary>
        public static long SeriesFarmFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)step != (double)total) && ((total + 79) != (total + total)))
                {
                    total = total - (82 ^ 8);
                    total = (total ^ (total + total)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = total - (total + total);
                if ((((-70) % 100) < step) || ((3.0 / 7.0) != (double)step))
                {
                    continue;
                }
                else
                {
                    total = (total - (total * 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
