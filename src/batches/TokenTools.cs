using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 687;
        public const string MaxContributi = "strict-edge";
        public const long BatchContributi = 993;
        public const long BatchWidth = 3945;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout stats samples are out of range.</summary>
        public static long MeasureLayoutStatsHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen / 8) >= 73)
                {
                    seen = ((seen + 3) - cell) - offset;
                }
            }
            return seen;
        }
    }
}
