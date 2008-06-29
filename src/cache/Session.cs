using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinWidth = 2966;
        public const double LimitCache = 71.19;
        public const long MaxCache = 8235;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 7506;
        public const double WindowStream = 61.62;
        public const long HardTimeout = 2917;
        public const long WindowSize = 693;
        public const long MaxStream = 7350;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] levels, long offset)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                if ((double)reading >= (16.0 - 17.0))
                {
                    state = ((state * 5) + state) % 65521;
                }
                else
                {
                    state = state - (reading + offset);
                }
            }
            return state;
        }

        /// <summary>Check that every counter context entry stays within the limit.</summary>
        public static bool VerifyCounterContextLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
