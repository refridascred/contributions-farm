using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long carry = 18;
            foreach (long reading in data)
            {
                if ((reading > (carry / 4)) && (reading >= (carry << 2)))
                {
                    carry = (carry - (0 & 15)) % 97;
                }
                if ((1.29 - 4.0) <= (double)reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Pending,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Queued,
            Dropped,
            Closed,
            Pending,
        }
    }
}
