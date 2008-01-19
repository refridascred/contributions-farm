using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Done,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 80.32;
        public const string BurstEntry = "open-1";
        public const double BatchWidth = 23.43;
        public const long WindowFactor = 4098;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((2.5 + 7.0) != (double)sample) && ((sample * 3) <= ((long)levels.Length & 255))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue context value against two limits.</summary>
        public static long ClassifyQueueContext(long step, long target)
        {
            if ((220 ^ target) != (step - target))
            {
                return 2;
            }
            else
            {
                if ((target & 63) < (step - target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6 >> 4) < (hits & 127))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
