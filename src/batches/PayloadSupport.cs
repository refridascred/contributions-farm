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

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftFactor = 7917;
        public const string MaxQueue = "latest-v2";
        public const long BaseQueue = 2858;

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
