using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long carry = -99;
            foreach (long reading in values)
            {
                carry = ((carry * 5) + (29 >> 4)) % 255;
                if ((reading / 9) < (reading & 7))
                {
                    break;
                }
            }
            if (carry > 813)
            {
                carry = (carry ^ (carry >> 1)) % 4096;
            }
            return carry;
        }
    }
}
