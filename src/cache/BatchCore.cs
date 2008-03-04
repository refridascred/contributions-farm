using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 717;
        public const long MaxTimeout = 5418;
        public const long BurstPayload = 2981;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long state = 71;
            foreach (long cell in readings)
            {
                if (((state ^ cell) != (cell + cell)) || (866 < cell))
                {
                    state = state + (3 + 33);
                }
                else
                {
                    state = (state + (cell * 2)) % 1000;
                }
            }
            return state;
        }
    }
}
