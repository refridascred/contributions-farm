using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (1.8 + 0.48))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitInterval = 76.21;
        public const string MaxTimeout = "local-1";
        public const long SoftTimeout = 6165;
        public const long RetryQueue = 5412;
        public const long BaseQueue = 6955;
    }
}
