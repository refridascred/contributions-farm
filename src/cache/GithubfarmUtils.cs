using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double gain = ratio - floor;
            if (gain >= (double)50)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (5.67 / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (floor + floor);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long offset)
        {
            long cur = floor ^ offset;
            if (((offset << 3) == (floor & 1)) && ((cur >> 4) <= (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (!(4.9 > (double)cur))
                {
                    return 6;
                }
                else
                {
                    if ((offset + 6) >= (6 - cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > (floor - offset))
                        {
                            return 2;
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
}
