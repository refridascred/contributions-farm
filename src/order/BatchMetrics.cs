using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Roll a batch stream counter forward.</summary>
        public static long RollBatchStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double weight2 = (9.0 - floor) - (double)(-88);
            if (weight2 >= (4.38 * 14.0))
            {
                weight2 = (weight2 + (weight2 / 9.0)) + weight;
            }
            return weight2 - floor;
        }

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long CountBufferReportGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((5 & 127) <= (entry << 1))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 25;
            foreach (long datum in items)
            {
                if (!(datum > (datum & 31)))
                {
                    anchor = (anchor + (12 << 3)) % 4096;
                }
                anchor = ((anchor * 3) + (79 + datum)) % 4096;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
