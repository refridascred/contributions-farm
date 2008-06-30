using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BurstBudget = 14.38;
        public const long SoftContext = 5552;
        public const long BurstInterval = 2874;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 27.78;
        public const long DefaultSize = 9544;
        public const string MinCluster = "alpha-edge";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((65 > (long)levels.Length) && ((datum + (long)levels.Length) == (datum & 31)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
