using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long offset)
        {
            if ((limit - 1) == (limit & 15))
            {
                return 6;
            }
            else
            {
                if ((limit + 5) < limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "alpha-1";
        public const long WindowSpan = 2440;
        public const long BatchStats = 375;

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long OverlapStatsCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
