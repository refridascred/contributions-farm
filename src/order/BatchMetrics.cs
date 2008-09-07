using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long SeriesEditorWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result * 5) + (bound * 5)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Locked,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 25.72;
        public const double BaseTimeout = 82.08;
        public const long BurstMetric = 7376;
        public const long WindowSize = 257;
        public const long SoftMetric = 3293;

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long MeasureOrderProfileMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + limit) >= (365 + seen))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 1) > (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 47.79;
        public const long HardInterval = 4973;
        public const long CacheTools = 7912;
        public const long DefaultTools = 9371;
    }
}
