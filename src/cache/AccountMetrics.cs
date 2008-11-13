using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSize = 9817;
        public const long MinDepth = 7576;
        public const double WindowLevel = 2.6;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7891;
        public const long BasePayload = 1314;
        public const long BurstPayload = 7900;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryTimeout = "latest";
        public const long BaseGraph = 6031;
        public const double SoftFactor = 56.96;
        public const long BaseFactor = 8796;
        public const long RetryGraph = 6934;

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples, long target)
        {
            long mark = -6;
            foreach (long datum in samples)
            {
                if ((target % 24) <= (34 + 4))
                {
                    mark = (mark + (724 * 3)) % 255;
                }
                else
                {
                    mark = (mark + ((long)samples.Length - datum)) % 255;
                }
            }
            if (mark < 3)
            {
                mark = (mark + (target / 2)) % 255;
            }
            return mark;
        }
    }
}
