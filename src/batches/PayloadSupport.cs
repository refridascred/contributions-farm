using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
