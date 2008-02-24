using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count < (datum << 1)) || ((double)count <= (11.0 + 1.0)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 4188;
        public const double HardGraph = 43.76;
        public const double StepGraph = 21.13;
        public const long CacheRatio = 2289;
        public const long CacheWidth = 3025;
    }
}
