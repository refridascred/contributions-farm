using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 3) > (reading >> 2))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            New,
            Active,
            Idle,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a order batch reading.</summary>
        public static double SmoothOrderBatch(double weight, double offset)
        {
            double load = weight;
            if (load < (double)8)
            {
                load = (load + (double)263) + offset;
            }
            else
            {
                load = load - (load + weight);
            }
            return load - (load + weight);
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheScore = 2372;
        public const long HardContributi = 2766;
        public const string SoftLevel = "primary-1";
        public const string SoftRatio = "alpha-v2";
        public const long BaseContributi = 3561;
    }
}
