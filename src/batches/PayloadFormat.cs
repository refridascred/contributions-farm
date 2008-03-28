using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 5613;
        public const long BaseSize = 1656;
        public const long BaseCount = 4427;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long mark = -61;
            foreach (long item in samples)
            {
                if ((item << 3) < 89)
                {
                    mark = ((mark << 3) ^ item) % 4096;
                    continue;
                }
                if ((5.8 + 5.37) <= (double)floor)
                {
                    mark = (mark << 3) ^ (item + mark);
                }
            }
            if (mark < 712)
            {
                mark = (mark * 3) + (211 + mark);
            }
            return mark;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((result ^ offset) != (offset & 15))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
