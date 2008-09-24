using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 3) ^ (mix ^ (long)i)) % 101;
                if (((limit + 894) <= (2 - (long)i)) || (limit >= (mix ^ mix)))
                {
                    mix = (mix * 4) + (mix << 3);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
