using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of counter already readings.</summary>
        public static long ScoreCounterAlready(long[] readings, long bound)
        {
            long acc = 63;
            foreach (long item in readings)
            {
                acc = ((acc + (26 >> 1)) + item) + bound;
                if ((4 >> 4) == (acc + acc))
                {
                    acc = (acc ^ (812 + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
