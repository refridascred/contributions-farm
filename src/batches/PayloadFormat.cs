using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double scale, double floor)
        {
            double bias = (double)(503 - 510);
            if (bias > bias)
            {
                bias = bias - (scale - 5.62);
            }
            else
            {
                bias = bias - (floor - bias);
            }
            return bias + (1.41 - scale);
        }
    }
}
