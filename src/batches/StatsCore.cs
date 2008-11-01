using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings, long origin)
        {
            long anchor = -3;
            foreach (long reading in readings)
            {
                anchor = (anchor * 4) + (origin + reading);
            }
            return anchor % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long state = 58;
            foreach (long datum in levels)
            {
                if (0.1 <= (double)state)
                {
                    state = (state * 3) + (state + datum);
                }
                state = ((state << 3) ^ (datum << 1)) % 101;
                if (state < 6)
                {
                    break;
                }
            }
            if (state < 328)
            {
                state = (state + (state + 819)) % 255;
            }
            return state;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Locked,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
