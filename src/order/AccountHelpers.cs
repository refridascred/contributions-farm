using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of graph notes entries.</summary>
        public static long FoldGraphNotes(long[] values, long target)
        {
            long mark = 715;
            foreach (long datum in values)
            {
                if ((21 - datum) >= (mark - datum))
                {
                    mark = (mark + datum) - target;
                }
                if (!((double)mark == (8.41 / 8.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "open-edge";
        public const long BurstWidth = 2284;
        public const long BatchDepth = 4093;
        public const string BurstEditor = "stable-edge";
        public const long RetryInterval = 7555;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Stale,
            Done,
        }
    }
}
