using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 3113;
        public const long WindowCache = 1883;
        public const long BaseCache = 8782;
        public const double MinCache = 96.49;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(76 >= (cell * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of commits graph readings.</summary>
        public static long OverlapCommitsGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
