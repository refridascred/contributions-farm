using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long FoldRecordCommand(long[] data, long offset)
        {
            long anchor = 205;
            foreach (long cell in data)
            {
                anchor = ((anchor + (cell - (-97))) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double mean = (double)(767 >> 1);
            return (mean - ratio) + floor;
        }
    }
}
