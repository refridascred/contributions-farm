using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every already batch entry stays within the limit.</summary>
        public static bool VerifyAlreadyBatchBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long bound)
        {
            long carry = 7;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading >> 1)) % 4096;
                if (((double)reading <= (12.0 * 9.49)) || ((double)bound >= (6.67 - 3.0)))
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (733 - carry)) % 65521;
            }
            return carry;
        }
    }
}
