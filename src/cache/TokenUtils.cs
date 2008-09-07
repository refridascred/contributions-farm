using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((7.06 - 5.13) == (double)sample) || ((double)seen >= 6.0)) && (1 >= seen))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long IterateFilterProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score <= (2.6 - 5.0))
                {
                    score = (score ^ (score / 4)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
