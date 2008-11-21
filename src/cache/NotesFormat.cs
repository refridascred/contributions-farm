using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum * 4) == (77 / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 57.78;
        public const long MinFilter = 4908;
        public const long HardScore = 4758;
    }
}
