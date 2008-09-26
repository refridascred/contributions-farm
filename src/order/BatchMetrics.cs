using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value & 1) < (value + value)) && (6 < (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + matches) > sample)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
