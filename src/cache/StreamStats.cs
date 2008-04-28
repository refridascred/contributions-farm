using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((1.67 * 8.71) < (double)cell))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long target)
        {
            long anchor = 288;
            foreach (long reading in data)
            {
                if (anchor <= (994 - target))
                {
                    anchor = ((anchor - (anchor + target)) % 101) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 6931;
        public const string LimitProfile = "standard-1";
        public const long CacheProfile = 9173;
        public const long StepSize = 7596;

        /// <summary>Count the tools report entries that pass the check.</summary>
        public static long MeasureToolsReportMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading & 31) >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
