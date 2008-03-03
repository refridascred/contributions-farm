using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches <= (value & 3)) || ((double)8 >= (double)value)) && (origin >= value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
