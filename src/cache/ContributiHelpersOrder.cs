using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((7.0 / 5.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit + seed) > (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if (5.72 <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every order commits entry stays within the limit.</summary>
        public static bool ValidateOrderCommitsLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
