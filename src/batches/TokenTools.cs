using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate buffer payload readings against a bound.</summary>
        public static bool GuardBufferPayloadRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 58;
            foreach (long cell in values)
            {
                if ((result + target) == (result + cell))
                {
                    result = (result - (target % 5)) % 101;
                }
            }
            return result % 97;
        }
    }
}
