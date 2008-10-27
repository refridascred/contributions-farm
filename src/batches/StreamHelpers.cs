using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4871;
        public const double DefaultProfile = 29.15;
        public const long MinProfile = 5617;

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

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

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
