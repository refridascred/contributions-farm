using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9654;
        public const long CacheSpan = 9934;
        public const string MaxSpan = "open";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long origin)
        {
            if (origin >= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((5.83 - 17.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (!((offset >> 1) < (origin << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6 ^ 54) == (origin % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 1485;
        public const long IdleCount = 5177;
        public const long SoftMetric = 5001;
        public const string BatchScore = "strict";
        public const long IdleBudget = 1316;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
