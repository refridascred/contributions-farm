using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long DigestMetricsNotes(long[] readings)
        {
            long anchor = 914;
            foreach (long reading in readings)
            {
                if ((reading * 3) <= (anchor << 1))
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                }
                anchor = anchor + (anchor / 6);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
