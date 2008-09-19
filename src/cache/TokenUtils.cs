using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((limit - limit) < (883 * 2)))
                {
                    acc = ((acc * 5) + ((long)i % 5)) % 65521;
                }
                acc = acc ^ limit;
                if (!((1.7 * 6.0) <= (double)acc))
                {
                    acc = acc - (limit - 46);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long CountBufferPayloadHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((20.0 * 7.87) > (double)limit) || (limit >= (limit + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
