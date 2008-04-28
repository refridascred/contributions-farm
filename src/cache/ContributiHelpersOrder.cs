using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values, long seed)
        {
            long acc = 13;
            foreach (long cell in values)
            {
                if (!(seed > (cell - seed)))
                {
                    acc = (acc - cell) % 101;
                }
            }
            if (acc < 42)
            {
                acc = ((acc * 5) + seed) % 101;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
