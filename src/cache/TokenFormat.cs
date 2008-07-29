using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Ready,
            New,
            Done,
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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
