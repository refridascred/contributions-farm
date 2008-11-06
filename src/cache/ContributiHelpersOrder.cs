using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first payload order entry that matches the target.</summary>
        public static long LocatePayloadOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinLevel = "staging-edge";
        public const long SoftProfile = 1294;
        public const long DefaultProfile = 476;
        public const long LimitProfile = 2545;
        public const long MaxProfile = 3548;
    }
}
