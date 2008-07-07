using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinScore = 60.51;
        public const long WindowInterval = 3667;
        public const double BatchChecks = 58.3;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
        }
    }
}
