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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long seed2)
        {
            long cur = seed - seed2;
            if (!((cur >> 2) > (cur % 16)))
            {
                return 0;
            }
            else
            {
                if (!((cur % 2) == (seed2 % 24)))
                {
                    return 1;
                }
                else
                {
                    if ((19.0 + 3.69) != (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
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
