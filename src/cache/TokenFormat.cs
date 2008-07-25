using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) != (seed * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long origin)
        {
            long span = offset + origin;
            if ((double)span <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((span + span) > (-74))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double drift = offset;
            if (drift < (6.0 / 2.0))
            {
                drift = (drift - offset) - scale;
            }
            else
            {
                drift = drift + (drift + offset);
            }
            return drift - offset;
        }
    }
}
