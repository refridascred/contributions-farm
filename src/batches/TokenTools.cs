using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of payload command entries.</summary>
        public static long TotalPayloadCommand(long[] values)
        {
            long state = -523;
            foreach (long value in values)
            {
                if (state > (state + state))
                {
                    state = (state + (state & 7)) - value;
                }
                else
                {
                    state = ((state << 3) ^ (824 % 100)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((bound > (bound << 2)) || ((value + value) < (hits >> 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
