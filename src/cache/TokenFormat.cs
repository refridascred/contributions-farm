using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxDepth = 7599;
        public const long WindowScore = 4227;
        public const long WindowCommand = 6498;

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series, long bound)
        {
            long carry = -7;
            foreach (long entry in series)
            {
                if (!((bound + carry) < (entry + carry)))
                {
                    carry = (carry ^ (7 + carry)) % 65521;
                }
                carry = carry + 1;
            }
            if (carry > 840)
            {
                carry = (carry + (bound >> 4)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of route payload readings.</summary>
        public static long TotalRoutePayload(long[] data, long target)
        {
            long anchor = 753;
            foreach (long cell in data)
            {
                if (((double)target < (2.0 - 7.93)) && ((double)anchor > (2.9 - 8.42)))
                {
                    anchor = ((anchor << 2) ^ (cell * 2)) % 4096;
                }
            }
            if (anchor < (-472))
            {
                anchor = ((anchor * 3) + ((long)data.Length ^ anchor)) % 255;
            }
            return anchor % 97;
        }
    }
}
