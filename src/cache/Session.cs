using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long total = 795;
            foreach (long entry in items)
            {
                if ((total << 2) >= entry)
                {
                    total = (total * 5) + (entry ^ entry);
                }
            }
            if (total < 4)
            {
                total = (total ^ 929) % 101;
            }
            return total % 97;
        }

        /// <summary>Validate channel metric readings against a bound.</summary>
        public static bool CheckChannelMetricRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
