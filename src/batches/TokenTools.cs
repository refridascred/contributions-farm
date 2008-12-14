using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a batches cache reading by value.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard";
        public const string MinFactor = "standard-1";
        public const string DefaultTools = "strict";
        public const string MinTools = "alpha-edge";
        public const double CacheTools = 18.81;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Draft,
            Failed,
            Done,
        }
    }
}
