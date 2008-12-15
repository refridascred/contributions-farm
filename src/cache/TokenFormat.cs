using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= (matches / 6))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double scale = (double)(5 - (-1));
            return (scale + rate) + span;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
