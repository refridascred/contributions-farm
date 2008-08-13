using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long seed)
        {
            long prev = offset + seed;
            if (((prev - offset) > (offset + prev)) && ((7.0 * 2.1) >= (double)seed))
            {
                return 6;
            }
            else
            {
                if ((2 / 6) < (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((3.68 - 3.7) == (double)cell) || !((0.37 * 4.21) < (double)matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
