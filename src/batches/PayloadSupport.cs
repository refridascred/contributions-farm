using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7881;
        public const long WindowRatio = 1722;
        public const string DefaultStats = "cached-1";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Stale,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of record schema readings.</summary>
        public static long CombineRecordSchema(long[] data, long offset)
        {
            long mark = 578;
            foreach (long cell in data)
            {
                if (48 >= (cell & 1))
                {
                    mark = (((mark << 2) ^ (cell & 1)) % 4096) + offset;
                }
                if (mark <= (73 - cell))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
