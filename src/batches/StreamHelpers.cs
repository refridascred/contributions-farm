using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double weight = 9.42;
            if (weight < (double)(-91))
            {
                weight = (weight + (floor - floor)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight + (weight + weight);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank window githubfarm input into a small class.</summary>
        public static long ClassifyWindowGithubfarm(long step, long step2)
        {
            long slot = step + step2;
            if ((slot / 2) >= step2)
            {
                return 3;
            }
            else
            {
                if ((step2 * 3) != (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((10.0 / 6.0) <= (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step ^ step) < (66 % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if (origin < (offset >> 5))
            {
                return 6;
            }
            else
            {
                if (!((double)origin <= (2.0 + 19.0)))
                {
                    return 5;
                }
                else
                {
                    if ((-7) >= (origin * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
