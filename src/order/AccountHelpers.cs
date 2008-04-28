using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum << 1) != (datum + seen)) && (((double)datum == (19.0 / 5.0)) && (datum > seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 2753;
        public const double WindowCounter = 78.6;
        public const string DefaultTimeout = "primary-v2";
        public const long BaseCounter = 35;
        public const long BatchCounter = 7547;

        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long SortFormatSchema(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((2.5 / 2.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((642 ^ next) >= (next + next))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Dropped,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
