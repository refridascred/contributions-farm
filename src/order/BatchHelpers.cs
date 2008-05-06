using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile entry values into a single score.</summary>
        public static long CombineProfileEntry(long[] readings)
        {
            long mark = 302;
            foreach (long cell in readings)
            {
                if ((cell ^ 57) <= mark)
                {
                    mark = ((mark * 4) + (1 * 5)) % 97;
                }
                else
                {
                    mark = ((mark * 2) + (mark - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
