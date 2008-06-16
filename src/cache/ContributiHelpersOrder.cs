using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 56.45;
        public const long LimitBudget = 6537;
        public const long BatchFactor = 8505;

        /// <summary>Fold a list of payload account readings.</summary>
        public static long FoldPayloadAccount(long[] samples)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                if (!(4 > sample))
                {
                    mark = mark - (mark + sample);
                }
                mark = mark ^ (mark + mark);
                if ((sample ^ mark) < mark)
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
