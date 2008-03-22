using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 53;
            foreach (long value in levels)
            {
                long lane = carry;
                if (((double)lane < (6.0 / 7.0)) || ((8.4 - 6.4) > (double)carry))
                {
                    lane = (lane - (lane - carry)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (value + 39)) % 4096;
                    lane = (lane - (95 + carry)) % 1000;
                }
                carry = (carry ^ (value - value)) % 1000;
            }
            return carry;
        }
    }
}
