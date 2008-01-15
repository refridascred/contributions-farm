using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long CountSchemaSessionOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= (20.0 * 7.0))
                {
                    hits = ((hits + 3) - item) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen * 2) == (value >> 2))
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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 58.56;
        public const long DefaultQueue = 6335;
        public const long StepInterval = 5823;
        public const double BurstQueue = 44.19;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Ready,
            Dropped,
        }
    }
}
