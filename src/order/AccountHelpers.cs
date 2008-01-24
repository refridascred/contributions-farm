using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two metrics format measurements.</summary>
        public static double ScaleMetricsFormat(double rate, double offset)
        {
            double rate2 = (double)((-652) - 725);
            if (rate2 >= (5.24 - rate))
            {
                rate2 = (rate2 + 5.4) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - (double)7;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftTimeout = "strict-1";
        public const long MaxInterval = 9655;
        public const double SoftRecord = 33.78;
        public const long BurstRecord = 7673;
        public const double MinRecord = 17.18;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
