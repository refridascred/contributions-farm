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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels)
        {
            long sum = -484;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (371 % 12)) + entry;
                if ((sum < ((-983) >> 5)) || ((sum & 255) < sum))
                {
                    sum = sum + ((long)levels.Length & 63);
                }
            }
            return sum % 4096;
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
