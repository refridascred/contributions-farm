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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((hits & 15) >= (sample - sample)) && (floor >= (sample * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long origin)
        {
            long diff = offset + origin;
            if ((double)diff <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((1 << 2) == (offset / 6))
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.8) <= (double)diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
