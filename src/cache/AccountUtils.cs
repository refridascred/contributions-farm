using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long ClassifyFormatSchema(long target, long floor)
        {
            if ((target % 97) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor >= (target + 814)) || ((floor / 7) > (target >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 5429;
        public const long RetryMetrics = 79;
        public const double BaseWidth = 16.98;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((double)seen == (3.0 + 7.38)) && (sample >= 185)) && ((seen << 2) >= (sample / 6)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
