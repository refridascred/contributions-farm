using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 97.3;
        public const long BatchLevel = 9545;
        public const double StepCount = 37.75;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first token stream entry that matches the target.</summary>
        public static long LookupTokenStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
