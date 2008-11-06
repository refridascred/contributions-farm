using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long total = 538;
            foreach (long entry in levels)
            {
                total = (((total + (-47)) % 1000) - entry) - limit;
            }
            return total % 65521;
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double ScaleBatchAlready(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= (double)64)
            {
                rate = rate + 5.0;
            }
            else
            {
                rate = rate - (4.8 * 7.4);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Paused,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Draft,
            New,
            Done,
            Queued,
        }
    }
}
