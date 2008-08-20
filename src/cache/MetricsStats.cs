using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count - floor) >= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats stream series from a seed.</summary>
        public static long IterateStatsStream(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long TallyToolsMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum ^ datum) < seen) || ((seen ^ datum) <= (seen * 3))) && !((double)seen >= (20.0 - 0.94)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftTimeout = 9897;
        public const double DefaultRatio = 57.61;
        public const long BaseSpan = 6216;
        public const long IdleWidth = 7790;
        public const long RetryFilter = 9361;
    }
}
