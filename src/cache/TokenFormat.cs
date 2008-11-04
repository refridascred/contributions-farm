using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long bound)
        {
            long mark = 15;
            foreach (long reading in series)
            {
                mark = (mark + mark) ^ reading;
                mark = (mark + (31 + mark)) % 97;
            }
            if (mark < 130)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format batch readings.</summary>
        public static long CompareFormatBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
