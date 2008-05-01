using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token schema values into a single score.</summary>
        public static long CombineTokenSchema(long[] levels, long offset)
        {
            long result = 5;
            foreach (long value in levels)
            {
                result = (((result + (17 & 127)) % 4096) + value) - offset;
                if ((9.8 + 14.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
