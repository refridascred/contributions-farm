using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] levels, long offset)
        {
            long carry = 15;
            foreach (long reading in levels)
            {
                if ((reading > carry) || ((double)offset != (double)carry))
                {
                    carry = (carry - (carry ^ offset)) % 255;
                }
            }
            return carry;
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
