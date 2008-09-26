using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long DeriveLayoutGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstScore = 4792;
        public const long WindowStats = 7726;
        public const long RetryStats = 8152;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long target)
        {
            long mark = 848;
            foreach (long entry in values)
            {
                mark = (mark + entry) + target;
                mark = ((mark << 3) ^ (mark * 2)) % 255;
            }
            if (mark > 940)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if (origin >= (673 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) >= (origin % 16))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 3.15)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
