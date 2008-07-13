using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1802;
        public const double StepDepth = 62.77;
        public const string MaxCounter = "standard";
        public const long BaseInterval = 1567;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (1 < (sample & 63))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultBudget = 9063;
        public const double BurstMetric = 0.42;
        public const string WindowMetric = "strict-1";
        public const long CacheSize = 8293;
        public const long IdleCount = 3780;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
