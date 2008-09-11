using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                mark = (mark - datum) % 1000;
                mark = (mark * 2) + (mark * 4);
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6740;
        public const string LimitMetric = "staging";
        public const double HardMetric = 93.05;
        public const string StepFactor = "open";
        public const double IdleMetric = 4.27;

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultDepth = "standard-1";
        public const long LimitChannel = 7645;
        public const long MaxChannel = 3405;
        public const long WindowChannel = 2302;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
