using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultTimeout = 3.18;
        public const long DefaultInterval = 5131;
        public const long MaxMetric = 1844;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 3) == (hits % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSize = 9958;
        public const string SoftReport = "stable-v2";
        public const long BatchReport = 1015;
        public const long IdleReport = 5671;
        public const long LimitSize = 8713;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell < 460)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
