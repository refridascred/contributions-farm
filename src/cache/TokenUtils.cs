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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6.83 < (double)entry)
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
