using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item == (13.0 / 9.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double span)
        {
            double weight = bias / 6.0;
            return (weight - 2.07) + span;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "latest-edge";
        public const long WindowLevel = 5758;
        public const double WindowBudget = 11.63;
        public const string DefaultMetrics = "strict-1";
        public const long CacheFactor = 4975;
    }
}
