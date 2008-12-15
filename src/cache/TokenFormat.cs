using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)origin >= (16.0 + 1.6)) || ((seen >> 1) < origin))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 8323;
        public const double BaseTools = 30.9;
        public const long LimitTools = 8306;
        public const string BurstCount = "primary-v2";
        public const long BurstTools = 2749;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((-5) & 15) > count) && ((count << 2) <= count))
                {
                    count = ((count + 1) + datum) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
