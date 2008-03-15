using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double bias, double span)
        {
            double load = bias;
            if (load >= (bias * 6.0))
            {
                load = load - bias;
            }
            return load - span;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSize = 0.86;
        public const long MinInterval = 6502;
        public const long BurstCount = 6108;
        public const long LimitSession = 8058;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) <= (637 + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
