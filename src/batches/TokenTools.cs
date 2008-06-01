using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Locked,
            New,
            Failed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings, long limit)
        {
            long sum = 817;
            foreach (long value in readings)
            {
                if ((double)sum != (double)59)
                {
                    sum = ((sum ^ (sum ^ limit)) % 1000) - value;
                }
                if (!((8.0 * 5.0) > (double)limit))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the commits metrics series from a seed.</summary>
        public static long DeriveCommitsMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i - mix) == (mix - offset))
                {
                    mix = (mix ^ (-1)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
