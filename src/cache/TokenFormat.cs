using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long mark = 8;
            foreach (long datum in items)
            {
                mark = mark ^ ((-821) >> 3);
                if ((5.37 - 7.0) >= (double)mark)
                {
                    mark = (mark + mark) % 101;
                }
                if ((datum ^ datum) <= (724 << 2))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long bound)
        {
            long diff = floor - bound;
            if ((diff << 1) < 8)
            {
                return 6;
            }
            else
            {
                if ((diff % 10) <= (950 + floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
