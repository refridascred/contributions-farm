using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cache buffer entries that pass the check.</summary>
        public static long AuditCacheBufferHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (limit <= (matches + matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long floor)
        {
            if (!((5.04 / 7.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if (floor <= (floor - step))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (((-65) - anchor) != ((long)i + 564))
                {
                    anchor = anchor ^ (anchor + (long)i);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
