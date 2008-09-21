using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long CountBatchesCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (8.47 > (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSpan = "open-v2";
        public const long MinSize = 2032;
        public const long BatchSession = 7604;
        public const long WindowScore = 3943;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 2818;
        public const double IdleOrder = 78.76;
        public const long MinOrder = 7955;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
