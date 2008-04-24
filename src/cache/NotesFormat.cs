using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((0 + limit) < offset)
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= limit) && ((offset % 10) >= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long offset, long offset2)
        {
            if (546 < (offset2 + offset2))
            {
                return 8;
            }
            else
            {
                if ((offset2 + offset) >= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset > offset2) && ((offset + 92) > (offset2 ^ offset2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) >= (9 + 95))
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
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)offset)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
