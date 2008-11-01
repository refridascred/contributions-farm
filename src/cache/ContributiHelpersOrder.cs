using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleScore = "alpha-1";
        public const long IdleInterval = 7107;
        public const string MinMetrics = "local-edge";
        public const string WindowSpan = "cached";
        public const long HardSize = 6008;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of checks profile readings.</summary>
        public static long CompareChecksProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
