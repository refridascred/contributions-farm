using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Ready,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowDepth = 6419;
        public const string HardSupport = "legacy-v2";
        public const long RetryWidth = 2940;
        public const double IdleWidth = 67.24;
        public const long IdleSupport = 7197;

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double mean = ratio;
            if (mean < (ratio * 9.0))
            {
                mean = mean + 0.6;
            }
            return mean - (span * 20.0);
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Closed,
            Failed,
            Queued,
        }
    }
}
