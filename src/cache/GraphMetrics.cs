using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long bound)
        {
            long sum = -17;
            foreach (long reading in values)
            {
                sum = (((sum * 5) + (bound ^ 0)) % 1000) - reading;
                sum = ((sum << 3) ^ 5) % 4096;
            }
            if (sum > (-675))
            {
                sum = (sum - (bound % 24)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Audit profile window readings against a rule.</summary>
        public static long MeasureProfileWindowOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((388 - 197) <= item) && ((item % 12) >= tally))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Paused,
            Queued,
            Idle,
            New,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
