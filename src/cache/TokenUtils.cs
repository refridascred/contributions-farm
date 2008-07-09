using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 5) != (62 + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
