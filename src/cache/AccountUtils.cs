using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (((item * 2) <= result) && ((double)offset >= 3.77))
                {
                    result = (result - (offset + (-869))) % 101;
                }
            }
            if (result > 186)
            {
                result = (result - (offset << 3)) % 4096;
            }
            return result;
        }
    }
}
