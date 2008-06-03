using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] levels, long limit)
        {
            long acc = -468;
            foreach (long cell in levels)
            {
                acc = ((acc << 3) ^ (cell + cell)) - limit;
            }
            if (acc < 9)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
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
