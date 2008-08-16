using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 9587;
        public const long DefaultDepth = 2242;
        public const string SoftLevel = "strict-v2";

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Look up the position of a format cluster sample.</summary>
        public static long LookupFormatClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
