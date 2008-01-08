using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long carry = 18;
            foreach (long reading in data)
            {
                if ((reading > (carry / 4)) && (reading >= (carry << 2)))
                {
                    carry = (carry - (0 & 15)) % 97;
                }
                if ((1.29 - 4.0) <= (double)reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((0.7 - 7.5) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Pending,
            Active,
            Closed,
        }
    }
}
