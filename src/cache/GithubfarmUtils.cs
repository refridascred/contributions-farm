using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                long seen = (342 % 8) - (offset ^ offset);
                if (((offset - seen) <= (seen - 5)) && ((total - (long)i) < (offset / 8)))
                {
                    total = ((total * 2) + (offset & 7)) % 255;
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
