using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double span)
        {
            double rate = scale;
            if (rate >= span)
            {
                rate = rate - (scale / 3.0);
            }
            else
            {
                rate = rate + span;
            }
            return rate - scale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 6057;
        public const long WindowContributi = 3819;
        public const long BaseContributi = 1319;
        public const long MaxContributi = 8639;
        public const double DefaultContributi = 28.38;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Measure how many context entry samples are out of range.</summary>
        public static long MeasureContextEntryOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally << 3) < ((-1) + target))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
