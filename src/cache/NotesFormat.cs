using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftSpan = "local-edge";
        public const long IdleCounter = 5681;
        public const string StepCounter = "standard-edge";
        public const double BatchFactor = 9.03;
        public const long DefaultInterval = 7111;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 3) != (long)values.Length)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
