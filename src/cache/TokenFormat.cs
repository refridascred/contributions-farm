using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardFactor = "local-edge";
        public const long IdleSize = 3298;
        public const long DefaultDepth = 7620;

        /// <summary>Validate commits cluster readings against a bound.</summary>
        public static bool CheckCommitsClusterLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool ValidateReportCommitsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
