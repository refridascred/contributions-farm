using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel stream readings against a rule.</summary>
        public static long TallyChannelStreamGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value >= (origin + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result - floor) % 97;
                result = result ^ (14 + (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
