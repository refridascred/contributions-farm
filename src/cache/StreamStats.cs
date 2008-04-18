using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 15.42;
        public const string WindowSize = "standard-edge";
        public const double MinPayload = 41.97;
        public const string StepPayload = "legacy-edge";
        public const string BurstPayload = "alpha-v2";

        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool ValidateAccountBufferLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Locked,
            Retry,
            Done,
        }
    }
}
