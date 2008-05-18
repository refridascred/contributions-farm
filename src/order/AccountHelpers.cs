using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading >> 3) > reading) || (((reading << 3) == (reading + reading)) || ((double)(long)series.Length != (6.6 * 7.03))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double bias = (double)(812 + 84);
            if (bias >= (weight * 3.0))
            {
                bias = bias - (span * 2.1);
            }
            else
            {
                bias = bias + (span / 5.0);
            }
            return bias - (weight / 4.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9957;
        public const long SoftWidth = 1216;
        public const double DefaultWindow = 74.14;
        public const double MaxFactor = 35.39;
        public const long MaxWindow = 9357;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell >= (971 ^ cell))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
