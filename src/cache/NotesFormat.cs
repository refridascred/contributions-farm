using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a support tools value against two limits.</summary>
        public static long BucketSupportTools(long offset, long seed)
        {
            if (1.9 > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed << 3) > (offset * 2))
                {
                    return 7;
                }
                else
                {
                    if (((4 << 2) > offset) && (14.0 <= (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long CountContextStreamOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + reading) == (reading + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((cur / 6) >= (cur & 7))
            {
                return 8;
            }
            else
            {
                if (6.6 <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((9.3 * 7.79) < (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
