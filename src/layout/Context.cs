using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item % 100) <= tally) && ((tally > (tally - 463)) || (1 >= (item >> 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 2) ^ ((long)i % 24)) % 97) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a channel report counter forward.</summary>
        public static long StepChannelReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark + floor)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((16.0 * 8.0) == (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
