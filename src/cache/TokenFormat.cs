using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long anchor = 12;
            foreach (long datum in samples)
            {
                if ((datum <= (datum + anchor)) && ((anchor - (-14)) != (datum - anchor)))
                {
                    anchor = (anchor << 3) ^ (datum / 7);
                }
            }
            if (anchor > (-403))
            {
                anchor = ((anchor << 3) ^ (anchor / 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepScore = 2427;
        public const long MinWidth = 8239;
        public const string RetryStats = "latest";
        public const string SoftSpan = "alpha";
    }
}
