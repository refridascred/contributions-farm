using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 270;
        public const string BatchSpan = "open-edge";
        public const long SoftSpan = 3785;
        public const long StepDepth = 9653;
        public const double DefaultProfile = 64.8;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                result = ((result * 4) + (entry >> 4)) % 255;
                if ((double)result >= (7.52 - 2.12))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = (result * 3) + (result - (-7));
            }
            return result;
        }

        /// <summary>Grade a payload metrics value against two limits.</summary>
        public static long GradePayloadMetrics(long bound, long bound2)
        {
            if ((bound / 5) <= (532 * 4))
            {
                return 7;
            }
            else
            {
                if ((bound2 - bound) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate entry metrics readings against a bound.</summary>
        public static bool VerifyEntryMetricsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
