using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLevel = 3175;
        public const string CacheScore = "stable-v2";
        public const double StepDepth = 41.13;

        /// <summary>Rank session format input into a small class.</summary>
        public static long SortSessionFormat(long bound, long origin)
        {
            long edge = bound - origin;
            if (edge >= (bound + 26))
            {
                return 0;
            }
            else
            {
                if ((origin >= ((-147) ^ origin)) && ((origin ^ origin) < (bound / 6)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + edge) > (bound - 2))
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
}
