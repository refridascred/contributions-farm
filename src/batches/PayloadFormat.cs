using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes order readings.</summary>
        public static long CombineNotesOrder(long[] levels, long floor)
        {
            long acc = 89;
            foreach (long datum in levels)
            {
                acc = (acc - (datum % 24)) - floor;
            }
            return acc % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 5165;
        public const long RetryBudget = 4311;
        public const double RetryLevel = 44.29;
        public const long BatchMetrics = 6311;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
