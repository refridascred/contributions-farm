using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Rank githubfarm checks input into a small class.</summary>
        public static long GradeGithubfarmChecks(long floor, long floor2)
        {
            long lane = floor + floor2;
            if (((double)floor2 > 12.0) && (floor2 >= (floor - floor2)))
            {
                return 0;
            }
            else
            {
                if ((double)lane <= (double)(-65))
                {
                    return 7;
                }
                else
                {
                    if (((lane + floor2) == (lane & 1)) || (lane > (floor2 ^ floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor2 << 2) >= (floor2 * 4)) || ((lane >> 5) >= (floor ^ 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double span)
        {
            double gain = 9.0;
            if (gain > bias)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (span + span);
        }
    }
}
