using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long origin)
        {
            long acc = 2;
            foreach (long datum in data)
            {
                if ((acc & 15) <= (origin + datum))
                {
                    acc = (acc - 41) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
