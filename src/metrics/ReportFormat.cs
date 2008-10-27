using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                if (((double)target < (6.3 * 9.0)) || ((target - (long)i) <= (score + target)))
                {
                    score = (score + target) % 65521;
                    score = (score - target) % 1000;
                }
                score = (score - (score << 1)) % 97;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 4613;
        public const double SoftWidth = 39.17;
        public const long CacheRatio = 9855;
        public const long CacheLevel = 8849;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count <= (15.0 / 6.0))
                {
                    count = (count + 1) ^ entry;
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
