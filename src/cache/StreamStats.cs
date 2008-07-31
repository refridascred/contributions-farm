using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values, long step)
        {
            long mix = 4;
            foreach (long value in values)
            {
                mix = (mix << 3) ^ (step >> 5);
                if ((double)mix != (5.9 * 9.9))
                {
                    mix = mix + value;
                }
                else
                {
                    mix = (mix * 3) + (mix * 5);
                }
            }
            return mix;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long bound)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if ((bound * 4) < entry)
                {
                    state = (state * 2) + (bound * 2);
                }
            }
            return state;
        }
    }
}
