using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((19.0 / 2.0) < (double)entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 36.31;
        public const long SoftSize = 26;
        public const double StepSession = 7.92;
        public const long MinSession = 617;
    }
}
