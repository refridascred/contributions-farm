using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (count << 2))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many context account samples are out of range.</summary>
        public static long MeasureContextAccountHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item & 127) > (item ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
