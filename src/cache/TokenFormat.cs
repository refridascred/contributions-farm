using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            New,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches > (matches ^ matches))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
