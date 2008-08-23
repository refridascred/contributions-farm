using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] values, long bound)
        {
            long carry = 398;
            foreach (long datum in values)
            {
                if (((long)values.Length << 3) != (0 & 255))
                {
                    carry = ((carry << 3) ^ (carry & 1)) % 97;
                }
                if (((bound - carry) >= (bound + bound)) || ((560 + carry) > (-96)))
                {
                    carry = (carry + (9 / 6)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum + (-50))) % 97;
                }
                if (!((6 << 2) <= (datum << 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (3.59 * 2.9))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }
    }
}
