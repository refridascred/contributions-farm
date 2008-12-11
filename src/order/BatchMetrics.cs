using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 2375;
        public const string DefaultTimeout = "latest";
        public const long HardWidth = 4581;
        public const double RetryInterval = 57.24;
        public const long IdleBudget = 2291;

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) <= 0)
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long offset)
        {
            long delta = origin + offset;
            if ((double)delta == (double)294)
            {
                return 0;
            }
            else
            {
                if ((16.0 * 7.0) != (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta + 0) <= (delta ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Queued,
            Failed,
            New,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double load = bias;
            if (load > (double)964)
            {
                load = (load + load) + span;
            }
            return load - (bias / 7.0);
        }
    }
}
