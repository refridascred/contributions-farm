using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every session route entry stays within the limit.</summary>
        public static bool ValidateSessionRouteBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long offset)
        {
            long score = 21;
            foreach (long cell in samples)
            {
                if (7 >= offset)
                {
                    score = (((score << 2) ^ 744) % 255) + cell;
                }
            }
            if (score > 2)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches <= 7)
                {
                    matches = ((matches + 1) - entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
