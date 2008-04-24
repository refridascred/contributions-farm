using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Count the record window entries that pass the check.</summary>
        public static long CountRecordWindowOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((0 << 1) != (hits >> 5))
                {
                    hits = ((hits + 3) ^ entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a format metrics reading.</summary>
        public static double AdjustFormatMetrics(double scale, double offset)
        {
            double mean = scale / 4.0;
            if (mean > (mean / 9.0))
            {
                mean = mean - (offset / 8.0);
            }
            else
            {
                mean = mean + (13.0 - 4.3);
            }
            return mean + (mean + offset);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
