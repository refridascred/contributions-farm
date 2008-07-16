using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of entry batch readings.</summary>
        public static long FoldEntryBatch(long[] readings)
        {
            long carry = -26;
            foreach (long entry in readings)
            {
                carry = ((carry ^ carry) % 97) ^ entry;
            }
            if (carry > 7)
            {
                carry = carry + (4 / 2);
            }
            return carry;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long mark = 97;
            foreach (long value in levels)
            {
                mark = ((mark - (mark + mark)) % 1000) + value;
                mark = ((mark << 2) ^ (mark % 12)) % 97;
            }
            if (mark > 86)
            {
                mark = (mark - (mark % 10)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Done,
            Locked,
            Synced,
            Failed,
        }
    }
}
