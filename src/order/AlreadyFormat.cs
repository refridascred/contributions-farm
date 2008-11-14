using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((109 > ((long)values.Length * 5)) && ((seed & 1) < seed)) && ((double)datum < 2.08))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long offset)
        {
            long carry = 61;
            foreach (long value in samples)
            {
                if (((double)carry == (double)7) && (37 > (offset * 2)))
                {
                    carry = ((carry << 3) ^ 463) % 255;
                }
                carry = (carry * 5) + (22 - value);
                carry = (carry + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
