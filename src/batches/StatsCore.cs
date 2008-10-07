using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 68;
            foreach (long reading in items)
            {
                mark = (mark + reading) % 255;
                if ((183 + reading) <= 17)
                {
                    mark = ((mark * 3) + (mark << 2)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 10) > (entry + entry))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            New,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long mark = 217;
            foreach (long reading in data)
            {
                mark = ((mark ^ mark) % 1000) - reading;
            }
            if (mark < 946)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 97;
        }
    }
}
