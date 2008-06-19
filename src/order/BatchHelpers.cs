using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) < (entry + entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchTimeout = "stable-edge";
        public const long SoftStream = 3750;
        public const string BaseStream = "alpha-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4777;
        public const long RetryCount = 6307;
        public const long BatchDepth = 2219;
    }
}
