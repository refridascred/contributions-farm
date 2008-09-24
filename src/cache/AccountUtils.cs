using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 3606;
        public const string StepInterval = "cached-edge";
        public const long BatchRoute = 958;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
