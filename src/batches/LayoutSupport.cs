using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((7.67 * 4.78) <= (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 1305;
        public const double SoftLevel = 11.51;
        public const long SoftBudget = 7459;
        public const long CacheNotes = 8002;

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels, long bound)
        {
            long anchor = 971;
            foreach (long sample in levels)
            {
                if (!(((sample << 3) > anchor) && ((5.2 + 3.0) <= (double)sample)))
                {
                    anchor = (anchor + (bound ^ bound)) % 97;
                }
                if (((19.0 * 3.0) > (double)bound) || ((double)anchor == (double)6))
                {
                    anchor = (anchor + bound) % 65521;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ (6 & 63)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples, long origin)
        {
            long result = 608;
            foreach (long value in samples)
            {
                if ((224 + value) < (result * 2))
                {
                    result = ((result << 3) ^ (origin - result)) % 65521;
                }
            }
            if (result > (-466))
            {
                result = ((result * 2) + (origin - origin)) % 4096;
            }
            return result;
        }
    }
}
