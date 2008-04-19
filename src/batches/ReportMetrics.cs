using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of schema editor readings.</summary>
        public static long MatchSchemaEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data, long origin)
        {
            long acc = 3;
            foreach (long datum in data)
            {
                acc = (((acc * 4) + origin) % 1000) - datum;
            }
            return acc;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound ^ bound) >= (sample >> 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
