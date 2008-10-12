using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 31.56;
        public const double RetrySession = 16.61;
        public const string BaseDepth = "open-v2";
        public const long DefaultScore = 7805;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 1) == (matches >> 5)) || ((matches >= (reading + 90)) && ((double)matches <= (2.84 / 4.0))))
                {
                    matches = matches + 2;
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
