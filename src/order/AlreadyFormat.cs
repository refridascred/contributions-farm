using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long CountCacheBatchesOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 5) < (592 + count))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Combine channel contributi values into a single score.</summary>
        public static long TallyChannelContributi(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc - (-80)) % 101) - entry;
            }
            return acc;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Ready,
            Closed,
            Active,
        }
    }
}
