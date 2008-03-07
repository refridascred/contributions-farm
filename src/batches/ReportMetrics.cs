using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (state + (-869))) % 97;
                state = state + (target ^ state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftBudget = 83.6;
        public const double BatchDepth = 7.65;
        public const string MinFormat = "standard-edge";
    }
}
