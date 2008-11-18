using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Draft,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                acc = (acc ^ (value >> 2)) % 101;
                acc = ((acc * 4) + (acc - value)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchBudget = "primary";
        public const string MinRatio = "alpha-1";
        public const double IdleTools = 55.25;
        public const long StepTools = 1258;
        public const long BurstTools = 7216;

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long target)
        {
            if ((floor ^ floor) <= (73 >> 5))
            {
                return 5;
            }
            else
            {
                if ((target + floor) < target)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
