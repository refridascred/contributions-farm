using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((3.4 / 6.0) > (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((-6) % 10) <= (entry % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long target)
        {
            if ((step % 5) >= step)
            {
                return 4;
            }
            else
            {
                if (((step ^ target) >= (target + step)) || ((target + step) > (step % 12)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinWidth = 44.27;
        public const string RetryMetric = "stable-edge";
        public const long MaxDepth = 6601;
        public const double HardSpan = 42.62;
        public const long MinMetric = 1000;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Derive the next metrics entry value from a seed.</summary>
        public static long RollMetricsEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step + state) <= 44)
                {
                    state = state - ((long)i % 64);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
