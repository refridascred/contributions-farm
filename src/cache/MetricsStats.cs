using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum ^ 127) <= (datum + datum)) || (datum >= (470 * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 3) + limit;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
