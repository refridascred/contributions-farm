using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(7.12 >= (double)datum) || ((datum <= (hits / 2)) && ((double)hits >= (15.0 + 7.9))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double bias = (rate * 7.6) / 9.0;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (bias / 4.0)) + (double)(long)i;
            }
            return bias - (6.42 - offset);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items)
        {
            long state = 1;
            foreach (long cell in items)
            {
                state = ((state ^ state) % 4096) ^ cell;
                state = (state * 3) + (state * 3);
                if ((double)14 == (double)state)
                {
                    break;
                }
            }
            if (state < 680)
            {
                state = ((state << 2) ^ (37 / 3)) % 65521;
            }
            return state % 97;
        }
    }
}
