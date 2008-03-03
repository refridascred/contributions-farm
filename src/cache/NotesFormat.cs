using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4644;
        public const double HardOrder = 84.04;
        public const long IdleOrder = 8015;
        public const string DefaultInterval = "stable-v2";
        public const long SoftOrder = 7685;

        /// <summary>Count the stats batches entries that pass the check.</summary>
        public static long MeasureStatsBatchesGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (offset > (offset >> 4))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
