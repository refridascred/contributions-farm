using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long target)
        {
            if (target > ((-69) >> 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.4 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Ready,
            Done,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data)
        {
            long carry = -9;
            foreach (long entry in data)
            {
                if ((entry / 4) <= entry)
                {
                    carry = (carry * 5) + (carry + entry);
                }
                if (carry >= (entry ^ 873))
                {
                    break;
                }
            }
            if (carry < (-13))
            {
                carry = carry - (carry - carry);
            }
            return carry % 97;
        }
    }
}
