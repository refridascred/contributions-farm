using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long score = 58;
            foreach (long datum in values)
            {
                score = ((score * 5) + datum) % 255;
                if ((1.18 < (11.0 + 6.6)) || ((score ^ limit) > datum))
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long carry = 11;
            foreach (long value in readings)
            {
                if (!(((long)readings.Length * 2) != (value - carry)))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            if (carry > 6)
            {
                carry = (carry - carry) % 255;
            }
            return carry;
        }
    }
}
