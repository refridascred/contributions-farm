using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if ((origin & 255) < origin)
                {
                    result = ((result << 2) ^ (origin + result)) + datum;
                }
                if ((double)0 >= (double)origin)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 2661;
        public const long StepTimeout = 1671;
        public const double StepCount = 83.85;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
