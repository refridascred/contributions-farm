using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum < (tally >> 3))
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((total ^ total) <= total)
                {
                    total = total + ((long)i & 15);
                    continue;
                }
                if (!((5.0 / 5.0) > (double)(long)i))
                {
                    total = total - (long)i;
                    total = (total - (365 + total)) % 255;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
