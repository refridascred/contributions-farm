using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item - (long)levels.Length) != (count % 5))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count metrics payload pairs that satisfy a relation.</summary>
        public static long MatchMetricsPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen < (6.0 * 2.89))
                {
                    seen = ((seen + 3) + value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
