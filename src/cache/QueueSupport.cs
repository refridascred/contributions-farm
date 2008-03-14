using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((66 + (long)i) < acc))
                {
                    acc = (acc - (acc + (long)i)) % 97;
                }
                if (5.0 >= (double)seed)
                {
                    long gap = acc;
                    acc = (acc - gap) % 101;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxScore = 53.29;
        public const long StepFilter = 2737;
        public const long StepSpan = 4307;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
