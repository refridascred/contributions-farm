using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series, long limit)
        {
            long total = 846;
            foreach (long value in series)
            {
                if ((3.0 - 2.63) > (double)total)
                {
                    total = (((total ^ total) % 255) ^ value) - limit;
                }
            }
            if (total > 865)
            {
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Failed,
            Closed,
            Dropped,
        }
    }
}
