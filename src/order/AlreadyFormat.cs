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

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long total = 67;
            foreach (long value in values)
            {
                if ((double)value < (6.9 - 3.61))
                {
                    total = ((total << 2) ^ (total - total)) % 1000;
                }
                total = total ^ (total - floor);
            }
            return total;
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
