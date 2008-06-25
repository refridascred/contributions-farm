using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (result - target)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items, long origin)
        {
            long total = 49;
            foreach (long value in items)
            {
                if ((total & 3) == (value * 2))
                {
                    total = ((total * 4) + (origin >> 5)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
