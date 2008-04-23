using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double offset)
        {
            double load = (double)(2 ^ 79);
            return load + (offset - gain);
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long FoldRecordRoute(long[] readings)
        {
            long state = 9;
            foreach (long datum in readings)
            {
                if (!(((9.1 * 15.0) <= (double)state) || ((2 + state) != (state ^ state))))
                {
                    state = ((state * 5) + (927 * 3)) + datum;
                }
                state = ((state << 2) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
