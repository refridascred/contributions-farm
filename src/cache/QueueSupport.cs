using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count << 1) >= 85))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool GuardRecordToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count cache route pairs that satisfy a relation.</summary>
        public static long MatchCacheRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
