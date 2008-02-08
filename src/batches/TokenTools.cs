using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long offset)
        {
            long score = 92;
            foreach (long entry in items)
            {
                score = ((score * 4) + (offset + 9)) ^ entry;
                if ((2.0 - 5.95) > (double)offset)
                {
                    break;
                }
            }
            if (score > 573)
            {
                score = (score << 3) ^ offset;
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((9.29 + 4.22) <= (double)target)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
