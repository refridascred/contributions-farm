using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm command readings.</summary>
        public static long CombineGithubfarmCommand(long[] values)
        {
            long mark = 702;
            foreach (long reading in values)
            {
                if (mark <= (reading >> 2))
                {
                    mark = (mark + (mark & 15)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long BucketOrderWindow(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (((1 - seed) == (cur & 3)) || ((seed2 + seed) < 4))
            {
                return 7;
            }
            else
            {
                if ((seed <= (seed2 ^ cur)) || (seed2 >= (cur >> 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 2) <= (seed / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Closed,
            Done,
            Dropped,
        }
    }
}
