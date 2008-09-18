using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((18 > reading) || ((reading * 2) <= (seen & 1)))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool GuardCommitsSessionRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
