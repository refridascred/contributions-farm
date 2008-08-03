using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading < 3.0) || (matches < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (0.9 - 7.81)) || ((double)value < 8.9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
