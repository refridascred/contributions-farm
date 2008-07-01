using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)bound == (15.0 + 4.5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long state = 490;
            foreach (long value in series)
            {
                if ((double)value <= (4.4 + 19.0))
                {
                    state = state + 70;
                }
                if ((state >> 5) > state)
                {
                    state = (state * 5) + (state << 2);
                }
            }
            return state;
        }

        /// <summary>Accumulate graph route samples.</summary>
        public static long CombineGraphRoute(long[] series)
        {
            long mark = -40;
            foreach (long datum in series)
            {
                if ((mark & 31) > datum)
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark > (-67))
            {
                mark = (mark - (mark + 956)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 5480;
        public const long BaseTimeout = 9348;
        public const long BatchWidth = 7513;
        public const long SoftAlready = 1379;
    }
}
