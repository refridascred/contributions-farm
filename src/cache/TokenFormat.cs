using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of metric order entries.</summary>
        public static long ScoreMetricOrder(long[] values)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if (((double)(long)values.Length < 8.2) && (datum < (-160)))
                {
                    carry = (carry * 3) + ((-859) + datum);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry / 5)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool GuardBatchesReportBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
