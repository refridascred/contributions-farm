using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels, long limit)
        {
            long mix = 55;
            foreach (long cell in levels)
            {
                mix = (mix + (limit + limit)) ^ cell;
            }
            return mix % 1000;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
