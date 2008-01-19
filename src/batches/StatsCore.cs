using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long CountPayloadFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((double)seen >= (2.8 * 3.0)) && ((item + item) == (item >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache payload entries.</summary>
        public static long TallyCachePayload(long[] values, long target)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (anchor - (item % 64)) % 101;
                anchor = anchor - (anchor - target);
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell - cell) >= cell) || ((cell >> 5) >= cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double bias = (double)(41 & 3);
            if (bias < ratio)
            {
                bias = bias - bias;
            }
            return bias + (offset + bias);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6 >> 4) < (hits & 127))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
