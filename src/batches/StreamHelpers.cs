using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value >> 4) <= (value + target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseLevel = 1771;
        public const long HardSize = 7535;
        public const string SoftGraph = "legacy-v2";

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long CountRecordMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (73 <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long MeasureWindowToolsMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((bound & 15) > (matches << 3))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Stale,
            Queued,
            Dropped,
            Synced,
        }
    }
}
