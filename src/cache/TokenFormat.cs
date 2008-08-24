using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                if ((6.76 + 19.0) > (double)carry)
                {
                    carry = (carry * 2) + (carry + entry);
                }
                if ((13.0 - 9.91) > (double)entry)
                {
                    carry = (carry * 3) + (entry - carry);
                }
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor + (anchor >> 5)) ^ (long)i) + value;
                }
                anchor = (anchor ^ (-6)) % 65521;
            }
            if (anchor < 38)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstDepth = "stable-v2";
        public const double MaxProfile = 96.59;
        public const string IdleInterval = "strict-v2";
    }
}
