using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + tally) <= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool CheckReportMetricsRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultLevel = 8152;
        public const string IdleFactor = "latest-1";
        public const long CacheInterval = 9375;
        public const long BurstNotes = 3464;

        /// <summary>Measure how many queue layout samples are out of range.</summary>
        public static long MeasureQueueLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((double)507 == (double)sample) || ((19.0 + 2.0) < (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
