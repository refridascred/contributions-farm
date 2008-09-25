using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long limit)
        {
            long mark = 67;
            foreach (long entry in readings)
            {
                mark = (((mark - (mark >> 3)) % 4096) - entry) - limit;
            }
            return mark % 1000;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
