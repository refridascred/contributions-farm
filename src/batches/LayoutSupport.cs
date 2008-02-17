using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of schema format readings.</summary>
        public static long MatchSchemaFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 16.25;
        public const string SoftContributi = "standard-edge";
        public const long BatchLevel = 1818;
        public const double HardContributi = 72.22;
        public const long DefaultDepth = 4859;

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 64.89;
        public const long MaxBudget = 5931;
        public const long MinCommand = 215;
        public const double HardCommand = 1.07;
        public const double SoftRatio = 96.32;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 8682;
        public const string HardCount = "open-edge";
        public const string StepProfile = "fallback-v2";
        public const long DefaultInterval = 3373;
    }
}
