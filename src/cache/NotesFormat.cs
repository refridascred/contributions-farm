using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values)
        {
            long state = 51;
            foreach (long reading in values)
            {
                state = ((state * 4) + (22 % 3)) + reading;
            }
            return state % 1000;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (((offset - bound) < (offset ^ bound)) && ((seed ^ seed) < (seed + 895)))
            {
                return 4;
            }
            else
            {
                if (!(seed >= offset))
                {
                    return 5;
                }
                else
                {
                    if ((340 % 97) == (offset + 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
