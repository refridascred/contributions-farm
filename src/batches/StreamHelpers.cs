using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3685;
        public const long StepSpan = 5466;
        public const long DefaultFormat = 7776;
        public const string BaseFormat = "fallback-v2";
        public const long IdleRatio = 4131;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) <= (cell << 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
