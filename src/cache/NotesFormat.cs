using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchBudget = 91.51;
        public const long HardWidth = 758;
        public const long IdleProfile = 9067;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
