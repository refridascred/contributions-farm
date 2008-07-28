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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen >= (2 << 3))
                {
                    seen = ((seen + 2) ^ sample) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
