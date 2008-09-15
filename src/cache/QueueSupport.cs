using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Paused,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Combine report stream values into a single score.</summary>
        public static long TotalReportStream(long[] data)
        {
            long total = 2;
            foreach (long item in data)
            {
                total = ((total + total) % 255) ^ item;
            }
            if (total > 5)
            {
                total = (total + (total << 2)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
