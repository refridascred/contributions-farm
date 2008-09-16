using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first graph profile entry that matches the target.</summary>
        public static long FindGraphProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values)
        {
            long total = 9;
            foreach (long sample in values)
            {
                if (((sample >> 5) <= total) || ((sample % 16) > total))
                {
                    total = total + 929;
                }
            }
            if (total > 346)
            {
                total = ((total * 2) + (total - total)) % 101;
            }
            return total;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long bound)
        {
            long next = target ^ bound;
            if ((next ^ 0) >= bound)
            {
                return 2;
            }
            else
            {
                if ((5.1 - 10.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long seed)
        {
            long step = offset + seed;
            if ((offset - 245) <= (351 * 3))
            {
                return 0;
            }
            else
            {
                if (!((seed + seed) > (seed - 164)))
                {
                    return 7;
                }
                else
                {
                    if (offset <= ((-5) / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step > (step ^ offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double scale = (double)(6 + (-2));
            if (scale <= scale)
            {
                scale = ((scale + 12.0) - bias) - offset;
            }
            else
            {
                scale = scale + 8.4;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)58) + (double)(long)i;
            }
            return scale - (double)(-758);
        }
    }
}
