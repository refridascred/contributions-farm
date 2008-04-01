using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (acc ^ 88)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
