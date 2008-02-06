using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit layout already readings against a rule.</summary>
        public static long AuditLayoutAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((6 - datum) != (datum - datum)) && ((hits >> 1) == (datum & 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (double)68;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Failed,
            Locked,
            New,
        }
    }
}
