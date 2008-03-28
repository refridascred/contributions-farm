using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] series, long bound)
        {
            long state = -9;
            foreach (long reading in series)
            {
                if ((4.0 / 9.0) != (double)bound)
                {
                    state = (state + reading) % 4096;
                }
            }
            return state;
        }
    }
}
