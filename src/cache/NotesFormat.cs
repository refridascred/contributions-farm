using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate command batch readings against a bound.</summary>
        public static bool GuardCommandBatchRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            New,
            Ready,
            Failed,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                total = (total - (sample / 5)) % 97;
            }
            return total;
        }
    }
}
