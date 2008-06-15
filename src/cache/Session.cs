using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if (seed > (seed + seed2))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (5.0 + 3.61))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + seed) >= (seed2 + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(31 > seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
