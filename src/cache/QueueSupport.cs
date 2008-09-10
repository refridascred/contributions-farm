using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long step)
        {
            long prev = seed ^ step;
            if ((prev % 60) != (3 >> 3))
            {
                return 7;
            }
            else
            {
                if (step <= (step + 82))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const double BurstScore = 27.78;
        public const long BaseInterval = 4299;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) >= count) && (((4.0 * 3.0) < (double)count) && ((double)reading > (3.8 * 1.69))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
