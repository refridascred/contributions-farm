using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long origin)
        {
            if ((6.4 + 5.8) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin != (9.8 + 5.86))
                {
                    return 0;
                }
                else
                {
                    if (!((10.0 - 15.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed ^ origin) > (48 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            if (((7.0 / 5.0) <= (double)origin) && ((54 + seed) < seed))
            {
                return 5;
            }
            else
            {
                if ((2.89 * 6.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) >= seed)
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

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = 8.0;
            if (bias < 20.0)
            {
                bias = (bias + bias) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - (double)(-560);
        }
    }
}
