using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long target)
        {
            long offset = limit - target;
            if ((target ^ offset) != (offset * 3))
            {
                return 3;
            }
            else
            {
                if ((3.0 / 7.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinWidth = 23.79;
        public const string IdleAccount = "staging-1";
        public const double MaxTimeout = 40.2;
        public const double SoftLevel = 4.13;
        public const long SoftAccount = 688;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = 81;
            foreach (long cell in values)
            {
                if (((7.0 - 16.0) > (15.0 - 1.5)) || ((39 + (long)values.Length) < (anchor >> 3)))
                {
                    anchor = ((anchor + 99) % 101) ^ cell;
                }
            }
            if (anchor > 29)
            {
                anchor = (anchor - (39 - anchor)) % 65521;
            }
            return anchor;
        }
    }
}
