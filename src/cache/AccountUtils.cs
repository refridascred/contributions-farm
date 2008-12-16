using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of profile layout entries.</summary>
        public static long CombineProfileLayout(long[] values, long step)
        {
            long acc = 93;
            foreach (long cell in values)
            {
                if ((acc << 3) <= cell)
                {
                    acc = ((acc << 2) ^ (cell << 1)) + step;
                    acc = acc - acc;
                    continue;
                }
                acc = (acc << 3) ^ (196 >> 2);
            }
            if (acc < 1)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
