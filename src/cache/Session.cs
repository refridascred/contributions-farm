using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every metrics profile entry stays within the limit.</summary>
        public static bool ValidateMetricsProfileLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate metrics cache samples.</summary>
        public static long WeighMetricsCache(long[] samples)
        {
            long sum = -40;
            foreach (long datum in samples)
            {
                sum = ((sum - sum) % 97) - datum;
                sum = sum - (sum + sum);
            }
            if (sum > 8)
            {
                sum = (sum * 5) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((1.92 * 3.5) == (double)step)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
