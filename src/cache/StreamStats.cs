using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ (acc << 3)) % 65521;
                acc = ((acc * 5) + (cell + acc)) % 65521;
                if ((cell & 3) >= cell)
                {
                    acc = (acc + (cell >> 5)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 8786;
        public const long BaseCount = 5365;
        public const double BatchSize = 61.91;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
