using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long TotalGraphEditor(long[] levels, long seed)
        {
            long acc = -81;
            foreach (long cell in levels)
            {
                if ((double)seed >= (5.84 / 4.0))
                {
                    acc = ((acc * 3) + cell) % 65521;
                    acc = ((acc << 2) ^ (cell & 7)) % 255;
                    break;
                }
                acc = acc - (acc & 63);
            }
            return acc % 1000;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Draft,
            Locked,
        }
    }
}
