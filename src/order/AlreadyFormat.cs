using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series, long origin)
        {
            long carry = 6;
            foreach (long item in series)
            {
                if ((item >= (7 & 15)) || (carry < (item + 220)))
                {
                    carry = (carry + (origin ^ item)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (0 & 63);
                }
                if ((origin - item) != (163 + item))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long total = 86;
            foreach (long reading in samples)
            {
                if (reading < (reading & 127))
                {
                    total = total ^ 1;
                }
                if ((reading << 1) >= total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
