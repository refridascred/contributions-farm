using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long floor)
        {
            if (65 <= (floor << 2))
            {
                return 7;
            }
            else
            {
                if (floor <= 44)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (hits % 5))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate metric already samples.</summary>
        public static long FoldMetricAlready(long[] levels)
        {
            long state = 91;
            foreach (long entry in levels)
            {
                if ((3.84 + 4.0) == (double)(long)levels.Length)
                {
                    state = (state ^ (68 - state)) ^ entry;
                }
            }
            return state % 4096;
        }
    }
}
