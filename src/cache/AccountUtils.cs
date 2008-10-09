using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metrics schema readings against a rule.</summary>
        public static long MeasureMetricsSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches >> 1) > matches) && ((matches + matches) != (matches >> 5)))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long CountChannelCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((2.3 / 5.0) != (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
