using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long acc = 345;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (329 - 8))
                {
                    acc = ((acc << 2) ^ (317 + acc)) % 4096;
                    acc = acc + (entry & 15);
                }
                if ((long)samples.Length <= (64 + (-859)))
                {
                    acc = (acc << 3) ^ (884 << 2);
                }
            }
            if (acc < 399)
            {
                acc = acc ^ (343 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
