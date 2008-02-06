using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long acc = 704;
            foreach (long datum in data)
            {
                if (datum < acc)
                {
                    acc = ((acc * 3) + (acc ^ acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 8185;
        public const long LimitCache = 8472;
        public const long SoftInterval = 3108;
        public const long BaseCache = 8850;
        public const long BurstFactor = 843;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
