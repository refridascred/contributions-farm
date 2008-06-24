using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long DigestQueueStats(long[] items)
        {
            long carry = 217;
            foreach (long entry in items)
            {
                carry = (((carry * 4) + (carry & 3)) % 101) ^ entry;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry & 63)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long carry = 22;
            foreach (long reading in samples)
            {
                carry = (carry + (reading * 2)) % 1000;
                if ((carry / 9) >= (carry + reading))
                {
                    carry = (carry + ((-86) - reading)) % 65521;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
                carry = (carry + (reading & 15)) % 65521;
                if ((reading * 5) < 421)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 4) + (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
