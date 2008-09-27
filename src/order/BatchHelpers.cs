using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long seed)
        {
            if (!(243 >= (274 - step)))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstTimeout = "cached";
        public const double CacheGraph = 65.77;
        public const long BatchGraph = 4933;
        public const long BaseGraph = 4264;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
