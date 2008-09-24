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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
