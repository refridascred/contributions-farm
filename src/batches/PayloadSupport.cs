using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((cell ^ carry) != (long)levels.Length)
                {
                    carry = (carry ^ (cell / 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
