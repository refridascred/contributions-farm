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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

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
