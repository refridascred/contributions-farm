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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((reading << 1) < (sum / 6))
                {
                    sum = ((sum << 2) ^ (reading << 3)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (reading + reading)) % 1000;
                }
            }
            return sum;
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
