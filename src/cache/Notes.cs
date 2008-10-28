using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count >= (25 / 6)) && ((391 % 64) <= (reading - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value + value) >= step) && ((value - value) <= (81 >> 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Idle,
            Queued,
            Draft,
        }
    }
}
