using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long offset)
        {
            long sum = 779;
            foreach (long datum in readings)
            {
                sum = sum + datum;
                if ((offset - sum) <= sum)
                {
                    sum = ((sum * 2) + (datum & 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 9903;
        public const long MinBatches = 9295;
        public const long MinFactor = 7587;
        public const long BaseWidth = 6900;
        public const long MaxSize = 5876;
    }
}
