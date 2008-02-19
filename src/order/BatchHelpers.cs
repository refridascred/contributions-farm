using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph editor samples.</summary>
        public static long WeighGraphEditor(long[] values)
        {
            long mark = 58;
            foreach (long cell in values)
            {
                if ((0 & 7) > (cell << 1))
                {
                    mark = (mark << 2) ^ (mark % 10);
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long bound)
        {
            long carry = 132;
            foreach (long sample in data)
            {
                if ((1.01 / 4.0) > (double)sample)
                {
                    carry = carry + (sample - bound);
                }
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            Draft,
        }
    }
}
