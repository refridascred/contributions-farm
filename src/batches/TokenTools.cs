using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings, long bound)
        {
            long score = 47;
            foreach (long item in readings)
            {
                score = score + bound;
                if ((item * 5) != ((-4) << 1))
                {
                    score = ((score * 3) + (bound << 2)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (773 / 9)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
