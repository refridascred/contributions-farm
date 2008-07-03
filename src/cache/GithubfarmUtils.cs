using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ (-69)) <= (datum >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((0.8 + 7.0) == (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen + reading) < reading))
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
