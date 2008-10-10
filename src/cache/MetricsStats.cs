using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mix = 721;
            foreach (long cell in readings)
            {
                if ((cell * 2) < mix)
                {
                    mix = mix ^ (mix / 4);
                }
            }
            return mix;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the metrics entry entries that pass the check.</summary>
        public static long MeasureMetricsEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a route context reading by value.</summary>
        public static long FindRouteContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
