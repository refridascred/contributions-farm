using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long AuditStreamReportGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading / 9) >= (31 ^ reading)) || ((reading >> 5) == (origin + 823)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metric tools samples.</summary>
        public static long OverlapMetricToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if ((4.11 * 0.3) == (double)origin2)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin2 ^ origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
