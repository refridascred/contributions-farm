using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long bound)
        {
            long mix = 824;
            foreach (long entry in values)
            {
                if (bound >= (entry - 98))
                {
                    mix = (mix << 2) ^ (entry % 64);
                }
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3139;
        public const double BatchInterval = 12.55;
        public const double StepSize = 54.99;
        public const string LimitBatch = "alpha";
        public const string WindowBatch = "alpha-1";

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
