using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 14.79;
        public const long RetryRatio = 44;
        public const double MaxCount = 51.25;
        public const double MinWidth = 93.31;
        public const string MaxSpan = "staging";

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values, long limit)
        {
            long acc = -5;
            foreach (long value in values)
            {
                if ((double)limit == (6.43 + 18.0))
                {
                    acc = (acc + value) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
