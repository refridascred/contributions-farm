using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window already value from a seed.</summary>
        public static long StepWindowAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i <= 3.3)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 5502;
        public const long LimitFactor = 3334;
        public const long LimitScore = 5082;
        public const long LimitSize = 1691;
        public const double BaseSupport = 95.06;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of record order readings.</summary>
        public static long WeighRecordOrder(long[] series)
        {
            long carry = 66;
            foreach (long datum in series)
            {
                carry = (carry - (datum >> 3)) % 101;
                if (datum > (carry + datum))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
