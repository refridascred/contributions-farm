using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double ScaleQueueContext(double ratio, double offset)
        {
            double gain = ratio - (offset / 4.0);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 9.09) - (double)(long)i;
            }
            return gain - 1.3;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((392 - limit) > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
