using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Idle,
            Draft,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 72.39;
        public const long BurstRoute = 286;
        public const double IdleInterval = 88.44;
        public const double BaseDepth = 66.4;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length & 15) > (548 + 490))
                {
                    seen = ((seen + 2) + cell) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
