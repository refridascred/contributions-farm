using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((56 * 4) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
