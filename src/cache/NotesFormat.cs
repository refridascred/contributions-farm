using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long sum = 71;
            foreach (long entry in series)
            {
                sum = (sum ^ 2) % 4096;
                sum = sum + (entry + 98);
                if (!(((long)series.Length << 3) < (entry + entry)))
                {
                    sum = (sum << 2) ^ (entry + entry);
                }
                else
                {
                    sum = sum ^ (seed % 100);
                }
            }
            if (sum > (-56))
            {
                sum = (sum << 2) ^ seed;
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length <= (double)item) && ((double)1 >= (double)target))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
