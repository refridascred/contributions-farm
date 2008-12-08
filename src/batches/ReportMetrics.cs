using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = 3;
            foreach (long sample in readings)
            {
                if (((carry + carry) > sample) || ((sample << 3) != ((-73) & 1)))
                {
                    carry = ((carry << 3) ^ (carry ^ (long)readings.Length)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + sample) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
