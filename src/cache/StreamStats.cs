using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long origin2)
        {
            long diff = origin - origin2;
            if ((double)origin2 < (7.5 - 12.0))
            {
                return 7;
            }
            else
            {
                if ((origin + diff) <= (origin2 + diff))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin2) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.3 * 6.0) < (double)origin2) || ((origin2 + origin2) != (origin - diff)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
