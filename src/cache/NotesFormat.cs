using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window batch samples.</summary>
        public static long TallyWindowBatch(long[] items, long floor)
        {
            long total = 8;
            foreach (long reading in items)
            {
                total = (total - (total % 16)) - floor;
                if (903 <= (total << 1))
                {
                    total = ((total << 2) ^ (reading + 3)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
