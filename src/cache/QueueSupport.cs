using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank record tools input into a small class.</summary>
        public static long GradeRecordTools(long origin, long bound)
        {
            long gap = origin + bound;
            if ((8.4 + 4.77) > (double)gap)
            {
                return 8;
            }
            else
            {
                if ((61 - gap) >= origin)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
