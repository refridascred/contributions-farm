using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 2784;
        public const long BatchSize = 223;
        public const long HardEntry = 5685;
        public const long HardLevel = 5518;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data, long step)
        {
            long result = 50;
            foreach (long sample in data)
            {
                if ((sample + 59) >= 700)
                {
                    result = (result * 2) + (step + sample);
                }
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((1.0 / 5.0) <= (double)floor) && ((18.0 <= (double)floor) && (9 >= (floor / 8))))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
