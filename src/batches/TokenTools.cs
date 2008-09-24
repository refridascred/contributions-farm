using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate contributi entry samples.</summary>
        public static long TotalContributiEntry(long[] values, long bound)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (((mix - (mix * 4)) % 65521) ^ value) + bound;
            }
            return mix % 1000;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
