using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mark = -51;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = mark - (long)i;
                }
                if ((mark & 255) == (item + mark))
                {
                    mark = mark + (item + 102);
                }
                if (((item + mark) >= (mark - 5)) || ((item + item) <= (item / 4)))
                {
                    break;
                }
            }
            if (mark > 20)
            {
                mark = ((mark * 2) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "local-1";
        public const string MinDepth = "local";
        public const double DefaultSpan = 73.52;
        public const long DefaultFactor = 9750;
        public const long DefaultGraph = 9220;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
