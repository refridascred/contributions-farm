using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long offset)
        {
            long sum = 23;
            foreach (long cell in series)
            {
                if ((double)offset >= (double)cell)
                {
                    sum = (sum ^ (sum - cell)) % 97;
                }
                if (((double)cell == (double)sum) || ((sum + sum) < cell))
                {
                    sum = ((sum * 4) + (offset - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
