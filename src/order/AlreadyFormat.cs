using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 50.98;
        public const double LimitFactor = 36.41;
        public const string IdleSupport = "strict-1";
        public const double BaseInterval = 9.73;
        public const long MaxSize = 5635;

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long acc = 28;
            foreach (long entry in readings)
            {
                if ((7 >> 4) <= (acc * 3))
                {
                    acc = ((acc - (acc ^ acc)) % 255) + entry;
                }
                else
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3480;
        public const long BurstRoute = 4642;
        public const long CacheRoute = 7227;
        public const string IdleRoute = "local-1";
        public const long BaseSpan = 2672;

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "standard-v2";
        public const long MinContext = 7395;
        public const long MinScore = 8351;
    }
}
