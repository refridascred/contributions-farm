using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long state = 81;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (datum + 5)) % 255;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "legacy-1";
        public const long SoftOrder = 3284;
        public const long SoftLevel = 1098;
        public const double StepBudget = 42.42;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
