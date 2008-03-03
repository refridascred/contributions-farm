using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinSize = 5883;
        public const long BurstFormat = 9612;
        public const string IdleFormat = "latest-edge";
        public const long BaseBudget = 5520;
        public const long MaxSize = 3810;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long acc = 96;
            foreach (long datum in items)
            {
                if (acc > (long)items.Length)
                {
                    acc = (((acc << 2) ^ acc) % 101) + datum;
                }
                else
                {
                    acc = (acc - (-977)) % 97;
                }
            }
            if (acc < 24)
            {
                acc = ((acc * 4) + ((long)items.Length % 3)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
