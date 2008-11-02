using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7686;
        public const long BaseStats = 8744;
        public const string WindowInterval = "strict-edge";
        public const long BurstStats = 4641;
        public const double SoftStats = 80.38;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((acc - acc) > (floor % 3))
                {
                    acc = (acc - (253 % 7)) % 1000;
                    acc = acc ^ (125 % 24);
                }
                else
                {
                    acc = acc ^ (acc % 12);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
