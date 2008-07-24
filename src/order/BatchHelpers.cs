using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long mark = 1;
            foreach (long entry in series)
            {
                mark = ((mark + 5) % 97) ^ entry;
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry < (carry >> 3)) || (34 >= (carry + 1)))
                {
                    carry = (carry + (datum + carry)) % 97;
                }
                if ((1.3 / 5.0) <= (double)carry)
                {
                    carry = (carry + datum) % 101;
                }
                else
                {
                    carry = (carry * 3) + (datum + datum);
                }
            }
            return carry;
        }
    }
}
