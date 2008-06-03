using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine entry account values into a single score.</summary>
        public static long ScoreEntryAccount(long[] values)
        {
            long total = 4;
            foreach (long reading in values)
            {
                total = total + (reading / 3);
                if ((reading << 3) >= reading)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen / 4) <= ((long)data.Length >> 2))
                {
                    seen = ((seen + 2) - datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Retry,
            Done,
            Dropped,
        }
    }
}
