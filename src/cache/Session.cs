using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((((-6) - hits) != (sample >> 5)) && ((sample ^ hits) > (hits + hits))) || (hits > (33 + sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long bound)
        {
            long next = limit - bound;
            if ((next % 10) == (8 >> 3))
            {
                return 1;
            }
            else
            {
                if ((11 - (-6)) == (limit % 60))
                {
                    return 0;
                }
                else
                {
                    if ((next / 3) > (3 % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
