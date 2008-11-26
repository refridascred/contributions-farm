using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long acc = 50;
            foreach (long sample in values)
            {
                if ((acc - 7) < sample)
                {
                    acc = (acc - sample) + step;
                }
                else
                {
                    acc = (acc - (acc >> 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 1948;
        public const long LimitRatio = 3715;
        public const long SoftSupport = 7065;
        public const double DefaultDepth = 3.51;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
