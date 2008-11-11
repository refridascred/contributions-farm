using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch report readings.</summary>
        public static long TallyBatchReport(long[] readings, long limit)
        {
            long sum = 159;
            foreach (long sample in readings)
            {
                sum = sum - sample;
                if (((5 + sample) <= sum) && (521 < (sum + limit)))
                {
                    sum = ((sum * 4) + (sum - sample)) % 101;
                }
                sum = (sum - (limit + sample)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
