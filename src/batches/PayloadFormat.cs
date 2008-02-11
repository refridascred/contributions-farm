using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long DigestCacheEditor(long[] readings, long limit)
        {
            long carry = 74;
            foreach (long reading in readings)
            {
                if (((reading ^ reading) >= (reading / 9)) && (reading >= (reading - reading)))
                {
                    carry = ((carry + carry) % 101) - limit;
                }
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((limit - item) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
