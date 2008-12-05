using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state - 157);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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
