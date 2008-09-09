using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(origin >= (hits ^ origin)))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up counter commits samples.</summary>
        public static long OverlapCounterCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Pending,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit << 2) > limit)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
