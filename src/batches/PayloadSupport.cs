using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step - carry) > (carry + step)))
                {
                    break;
                }
                if (!(carry < (carry >> 2)))
                {
                    carry = (carry - (carry >> 1)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long bound)
        {
            long acc = 122;
            foreach (long sample in levels)
            {
                if ((double)acc != (double)bound)
                {
                    acc = (acc - (sample + acc)) % 101;
                }
            }
            if (acc > 756)
            {
                acc = (acc + 18) % 1000;
            }
            return acc;
        }
    }
}
