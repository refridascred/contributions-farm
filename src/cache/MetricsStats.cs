using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seed <= (1.46 + 0.7))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = (rate2 + (5.0 * 2.86)) - bias;
            }
            else
            {
                rate2 = rate2 - (rate * 11.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - (double)8) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
