using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((acc * 5) >= (limit + (long)i))
                {
                    acc = (acc * 5) + (limit - (long)i);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long SeriesTokenRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = total + (total - limit);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
