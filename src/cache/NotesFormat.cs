using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = ((acc - (acc << 1)) % 65521) - cell;
                if ((acc + acc) == (acc / 4))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + (acc ^ (long)values.Length)) % 101;
                }
            }
            if (acc > (-150))
            {
                acc = (acc + (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleInterval = "local-v2";
        public const long MaxLevel = 5288;
        public const string DefaultEditor = "cached-v2";
        public const long RetryEditor = 855;
        public const double IdleEditor = 37.37;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
