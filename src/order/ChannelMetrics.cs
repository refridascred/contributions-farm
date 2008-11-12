using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a metrics checks counter forward.</summary>
        public static long DeriveMetricsChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                long span = (result % 60) >> 1;
                result = (result - (bound ^ span)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen == (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
