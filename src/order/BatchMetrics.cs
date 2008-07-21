using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheFactor = 3616;
        public const long CacheSupport = 1634;
        public const long MinBudget = 881;
        public const long SoftDepth = 13;
        public const string BaseSupport = "strict-1";

        /// <summary>Check that every order counter entry stays within the limit.</summary>
        public static bool CheckOrderCounterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long step)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((((mark * 5) + 0) % 1000) - item) - step;
            }
            return mark % 4096;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
