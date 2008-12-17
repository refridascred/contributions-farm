using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count ^ target) > (992 + count))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((13.0 * 0.4) <= (double)item) || !((909 + item) > item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
