using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every route window entry stays within the limit.</summary>
        public static bool GuardRouteWindowLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally > (1.6 / 4.0))
                {
                    tally = ((tally + 3) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit cluster schema readings against a rule.</summary>
        public static long CountClusterSchemaHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) == (limit + (-323)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit payload account readings against a rule.</summary>
        public static long MeasurePayloadAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.82 / 9.0) >= (double)matches) || ((double)matches != (3.4 * 1.0)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
