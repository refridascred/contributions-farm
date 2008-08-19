using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route queue entries.</summary>
        public static long TallyRouteQueue(long[] readings)
        {
            long score = 7;
            foreach (long entry in readings)
            {
                if (((entry + score) >= 7) || (score < (score + entry)))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Find the first stream payload entry that matches the target.</summary>
        public static long FindStreamPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
