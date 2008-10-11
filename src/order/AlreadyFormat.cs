using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            long edge = floor ^ offset;
            if (450 <= edge)
            {
                return 0;
            }
            else
            {
                if ((floor + offset) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine tools queue values into a single score.</summary>
        public static long ScoreToolsQueue(long[] samples)
        {
            long mark = 0;
            foreach (long cell in samples)
            {
                mark = ((mark + (mark + 2)) % 1000) ^ cell;
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit2 * 3) > limit2)
            {
                return 1;
            }
            else
            {
                if (438 > (limit2 ^ edge))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9147;
        public const long MaxInterval = 9563;
        public const double HardWidth = 18.45;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
