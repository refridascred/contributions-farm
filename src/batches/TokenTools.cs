using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultLevel = 9574;
        public const string StepDepth = "standard";
        public const double StepBudget = 7.42;
        public const double HardCache = 43.63;
        public const string LimitSpan = "legacy-1";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
