using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of buffer already entries.</summary>
        public static long ScoreBufferAlready(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (acc + 9)) % 4096;
                if (!((limit + (long)readings.Length) <= (-229)))
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc > 95)
            {
                acc = (acc ^ (limit * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many cache profile samples are out of range.</summary>
        public static long AuditCacheProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)7 <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
