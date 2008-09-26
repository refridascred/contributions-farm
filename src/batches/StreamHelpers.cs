using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long TallySessionSupportOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.43 + 0.8) >= (double)value)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "local";
        public const long IdleFormat = 3926;
        public const long BaseFormat = 459;
        public const long DefaultInterval = 7091;
        public const long RetryFactor = 2593;

        /// <summary>Project the next checks schema value.</summary>
        public static double AdjustChecksSchema(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio * 14.0)) - (double)(long)i;
            }
            return ratio - (double)41;
        }
    }
}
