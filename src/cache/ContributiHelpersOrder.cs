using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            if ((2.0 + 2.07) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (origin >= (seed / 9))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long result = 584;
            foreach (long entry in items)
            {
                result = result - (entry % 64);
            }
            if (result > 791)
            {
                result = ((result << 2) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Queued,
            Done,
        }
    }
}
