using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 9.7)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long mark = 301;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark - (mark << 2)) - (long)i;
                }
                if (((mark * 2) != (sample << 3)) && ((double)mark > (double)sample))
                {
                    mark = ((mark << 3) ^ (sample / 2)) % 1000;
                }
                if ((sample << 2) > mark)
                {
                    mark = mark + ((-64) + mark);
                }
                if (!((mark - mark) < sample))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 50.65;
        public const double BaseWidth = 93.54;
        public const long BurstSpan = 9858;
        public const long StepSpan = 7479;
        public const long MinFactor = 2596;
    }
}
