using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every cluster buffer entry stays within the limit.</summary>
        public static bool ValidateClusterBufferRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long origin)
        {
            long state = 40;
            foreach (long entry in items)
            {
                if (((double)entry != (double)44) && (state < (4 & 7)))
                {
                    state = state - origin;
                    state = (state ^ entry) % 1000;
                }
                if ((long)items.Length > entry)
                {
                    state = (state - state) % 97;
                    continue;
                }
                else
                {
                    state = state - (40 * 4);
                }
                state = (state * 4) + entry;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Draft,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "latest-v2";
        public const double CacheWidth = 19.98;
        public const long BatchNotes = 1194;
        public const long StepNotes = 5665;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowLevel = 94.53;
        public const string LimitLevel = "fallback";
        public const long BaseSchema = 6870;
        public const long HardInterval = 4839;
        public const long StepSchema = 6349;
    }
}
