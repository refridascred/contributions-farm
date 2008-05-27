using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many schema cache samples are out of range.</summary>
        public static long MeasureSchemaCacheGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((84 + 1) == (value % 2))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "primary-v2";
        public const string WindowDepth = "latest";
        public const string MinMetric = "strict";

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples)
        {
            long total = 593;
            foreach (long reading in samples)
            {
                if ((541 % 64) >= (reading & 15))
                {
                    total = total ^ (reading + reading);
                }
                if (((double)total == (double)30) || ((reading % 12) <= (total << 3)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
