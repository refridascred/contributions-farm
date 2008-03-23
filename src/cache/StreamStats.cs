using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a checks layout sample.</summary>
        public static long FindChecksLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxLevel = 7897;
        public const string WindowLevel = "staging";
        public const long HardCluster = 1052;

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultTimeout = "latest-v2";
        public const long BaseEditor = 6585;
        public const double StepEditor = 79.76;
        public const long BatchScore = 5344;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
