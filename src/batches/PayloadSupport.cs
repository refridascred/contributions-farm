using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            New,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (reading >> 2);
            }
            return carry % 97;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool ValidateProfileWindowRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
