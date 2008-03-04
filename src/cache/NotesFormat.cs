using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long acc = 501;
            foreach (long item in items)
            {
                if (item > (acc % 100))
                {
                    acc = (acc - acc) % 4096;
                    continue;
                }
                acc = (acc ^ (acc / 9)) % 4096;
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            New,
            Locked,
            Closed,
            Dropped,
        }
    }
}
