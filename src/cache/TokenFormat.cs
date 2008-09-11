using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 11.42;
        public const string RetrySpan = "primary-edge";
        public const long DefaultTimeout = 9780;
        public const string BaseBudget = "alpha-v2";
        public const long BaseProfile = 7062;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long mark = 3;
            foreach (long cell in series)
            {
                mark = (mark * 2) + (long)series.Length;
                if ((662 % 10) <= (cell ^ cell))
                {
                    mark = mark - (mark >> 1);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }
    }
}
