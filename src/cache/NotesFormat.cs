using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long CountGithubfarmStreamGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((6.5 * 5.3) >= 14.0)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long acc = 436;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc + acc) + (long)i) + datum;
                }
                acc = ((acc << 2) ^ 9) % 97;
            }
            return acc;
        }

        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool CheckChecksSupportRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
