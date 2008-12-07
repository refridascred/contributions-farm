using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "strict";
        public const double BurstFormat = 25.18;
        public const long DefaultBudget = 634;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long WeighFarmStream(long[] readings, long bound)
        {
            long mark = 407;
            foreach (long datum in readings)
            {
                if ((1.79 / 3.0) < (double)bound)
                {
                    mark = (mark + (mark ^ mark)) ^ datum;
                }
            }
            if (mark < 96)
            {
                mark = ((mark * 5) + (mark + 307)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
