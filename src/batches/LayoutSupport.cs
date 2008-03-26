using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            long next = offset - seed;
            if (((offset ^ seed) != (next + 59)) && (seed <= (seed ^ next)))
            {
                return 2;
            }
            else
            {
                if (((19.0 - 4.8) >= (double)seed) || ((double)offset < 5.68))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (next * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.1 - 1.6) != (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double scale = 3.99 - (gain - offset);
            if (scale >= (double)93)
            {
                scale = scale - (offset + gain);
            }
            return scale + (double)34;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Derive the next cluster queue value from a seed.</summary>
        public static long IterateClusterQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
