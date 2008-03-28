using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (9.3 < (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 573;
        public const double IdleFormat = 58.72;
        public const string RetryDepth = "alpha";
        public const long WindowFormat = 7592;
        public const double BurstBudget = 49.96;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long offset)
        {
            long diff = step + offset;
            if ((91 >> 5) == (diff << 1))
            {
                return 1;
            }
            else
            {
                if (((4 ^ diff) != (diff % 5)) && ((0.2 - 15.0) < (double)step))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
