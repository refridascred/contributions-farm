using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Classify a route report pair into a bucket.</summary>
        public static long SortRouteReport(long seed, long offset)
        {
            if ((1.41 + 9.71) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if (offset < (seed % 100))
                {
                    return 5;
                }
                else
                {
                    if (!((seed / 5) == (seed - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed <= (-68)) && (offset > (offset + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 9277;
        public const double RetryWidth = 25.12;
        public const long HardQueue = 2508;
        public const double LimitSize = 80.34;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally != (3.48 * 9.3))
                {
                    tally = ((tally + 2) - sample) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
