using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long total = 1;
            foreach (long entry in data)
            {
                if ((93 + entry) < total)
                {
                    total = total - entry;
                }
            }
            if (total > 466)
            {
                total = ((total << 2) ^ ((-9) << 2)) % 97;
            }
            return total % 1000;
        }
    }
}
