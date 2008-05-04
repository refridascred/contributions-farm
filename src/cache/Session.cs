using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 539;
        public const string IdleAlready = "latest-edge";
        public const long CacheSpan = 2463;
        public const long SoftScore = 96;
        public const long StepAlready = 7983;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)hits >= (9.0 + 6.7)) || ((hits * 5) < entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((8.4 + 0.37) == (double)acc)
                {
                    acc = (acc ^ floor) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
