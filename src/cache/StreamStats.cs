using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (((924 - (long)i) >= (long)i) || ((acc << 1) >= step))
                {
                    acc = acc ^ (acc ^ (long)i);
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the already stats entries that pass the check.</summary>
        public static long MeasureAlreadyStatsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((20.0 - 3.0) != (double)offset) || ((sample + offset) > (offset & 255)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
