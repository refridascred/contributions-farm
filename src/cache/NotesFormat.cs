using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 7744;
        public const double IdleSize = 0.55;
        public const double IdleRecord = 66.62;
        public const string MaxFactor = "standard-v2";
        public const long MinDepth = 9429;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 2) == ((long)data.Length * 2))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
