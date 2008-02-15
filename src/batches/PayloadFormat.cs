using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a stats metric counter forward.</summary>
        public static long SeriesStatsMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (seed % 2)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long mark = 710;
            foreach (long datum in items)
            {
                if (!((mark > ((long)items.Length ^ datum)) && ((mark + datum) > mark)))
                {
                    mark = (mark ^ (datum / 9)) % 97;
                }
                if ((12.0 * 9.1) == (double)datum)
                {
                    mark = mark - (datum & 7);
                }
            }
            return mark;
        }
    }
}
