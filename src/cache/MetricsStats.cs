using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long origin)
        {
            long step = offset - origin;
            if ((double)offset <= (7.7 / 2.0))
            {
                return 4;
            }
            else
            {
                if (step <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + (reading - reading)) % 1000;
            }
            if (state > (-673))
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 62.3;
        public const long LimitSize = 8741;
        public const long RetryFormat = 7578;
        public const long BaseFormat = 636;
        public const long BurstFactor = 166;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long bound)
        {
            long acc = 15;
            foreach (long value in items)
            {
                if ((double)acc < 4.0)
                {
                    acc = (acc - (bound & 63)) ^ value;
                }
            }
            if (acc < 417)
            {
                acc = (acc - (acc - bound)) % 101;
            }
            return acc;
        }
    }
}
