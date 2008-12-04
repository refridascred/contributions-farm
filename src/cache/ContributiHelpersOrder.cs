using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 93;
        public const double BaseWidth = 97.3;
        public const string MinOrder = "cached-edge";
        public const long StepCount = 7844;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                if (floor > (total % 5))
                {
                    total = (total - (12 + (long)i)) % 1000;
                }
                else
                {
                    total = (total * 2) + (floor * 3);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
