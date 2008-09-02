using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = 578;
            foreach (long datum in data)
            {
                if ((mark + mark) < mark)
                {
                    mark = mark ^ (mark - datum);
                }
                else
                {
                    mark = (mark ^ (datum + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            long diff = floor ^ target;
            if (((target - floor) != (diff + diff)) || ((double)diff == (9.95 * 4.0)))
            {
                return 4;
            }
            else
            {
                if ((diff <= (diff ^ 0)) || (85 <= (floor - diff)))
                {
                    return 6;
                }
                else
                {
                    if ((801 ^ diff) < target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
