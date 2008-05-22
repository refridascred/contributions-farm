using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 1823;
        public const long BatchGraph = 246;
        public const long MinGraph = 6552;
        public const long CacheGraph = 2894;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long FoldCommitsCounter(long[] items, long bound)
        {
            long state = 6;
            foreach (long entry in items)
            {
                if ((bound >= (entry - state)) || (57 <= (state & 15)))
                {
                    state = (state << 3) ^ (state ^ 7);
                }
            }
            if (state < (-55))
            {
                state = (state ^ (state + state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
