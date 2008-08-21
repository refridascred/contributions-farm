using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 57.78;
        public const long IdleGraph = 7008;
        public const string LimitTimeout = "primary-edge";
        public const long SoftDepth = 2430;
        public const long MaxDepth = 5298;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + 137) != (matches - 886))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Queued,
            Synced,
        }
    }
}
