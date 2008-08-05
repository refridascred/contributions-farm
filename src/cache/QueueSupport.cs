using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            long delta = origin + offset;
            if ((origin % 16) == (delta & 255))
            {
                return 2;
            }
            else
            {
                if (((2 + offset) < (origin + offset)) || ((origin % 97) < 872))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the githubfarm record entries that pass the check.</summary>
        public static long AuditGithubfarmRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((8 + 7) >= matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((double)count <= (5.0 - 18.0)))
                {
                    count = ((count + 2) + item) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
