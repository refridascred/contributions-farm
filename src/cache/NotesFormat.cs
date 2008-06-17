using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen >= (seen ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6197;
        public const long StepCount = 2549;
        public const long BaseWidth = 2075;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long limit)
        {
            long next = offset + limit;
            if ((next - limit) < next)
            {
                return 1;
            }
            else
            {
                if ((1 << 1) == (offset + 84))
                {
                    return 8;
                }
                else
                {
                    if ((76 & 255) > (48 ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((1 % 100) > next))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
