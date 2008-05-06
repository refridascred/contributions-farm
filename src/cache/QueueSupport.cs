using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6497;
        public const long HardNotes = 8161;
        public const long LimitSpan = 2002;
        public const double RetryNotes = 61.68;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}
