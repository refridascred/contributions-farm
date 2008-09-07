using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of graph tools readings.</summary>
        public static long ScoreGraphTools(long[] data, long step)
        {
            long result = 75;
            foreach (long datum in data)
            {
                result = (result + datum) % 1000;
                result = ((result * 4) + (result - result)) % 1000;
                if ((9.0 + 6.0) != (double)step)
                {
                    result = (result - (result * 2)) % 255;
                }
                if (!((5.93 * 5.0) < (double)step))
                {
                    break;
                }
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

        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long MeasureFarmNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < 1.05)
                {
                    seen = seen + 1;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 41.91;
        public const long BurstMetrics = 3219;
        public const long IdleWidth = 9571;
    }
}
