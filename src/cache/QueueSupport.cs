using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Ready,
            Synced,
        }
    }
}
