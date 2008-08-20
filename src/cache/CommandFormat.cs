using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "alpha-edge";
        public const long MinBudget = 8852;
        public const long StepWindow = 8573;
        public const double DefaultWindow = 73.64;
        public const double LimitWindow = 35.04;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (6.39 * 4.4))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long state = 482;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (value ^ origin)) % 97;
            }
            return state;
        }
    }
}
