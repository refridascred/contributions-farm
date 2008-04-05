using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)9)
            {
                bias2 = (bias2 - (double)44) - ratio;
            }
            return bias2 - (bias2 - 3.07);
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - item) < (item ^ item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length + reading) > 23)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
