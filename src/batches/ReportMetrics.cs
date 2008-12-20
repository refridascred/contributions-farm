using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if (((mark - mark) >= (item << 1)) || ((230 + 78) < (item + 45)))
                {
                    mark = ((mark << 3) ^ (item & 63)) % 97;
                }
                if ((233 - mark) <= (mark >> 4))
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ (step >> 2)) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 55.26;
        public const double BatchCommand = 31.14;
        public const double WindowSpan = 64.96;

        /// <summary>Combine schema account values into a single score.</summary>
        public static long ScoreSchemaAccount(long[] levels)
        {
            long anchor = -84;
            foreach (long value in levels)
            {
                if (anchor >= (anchor + value))
                {
                    anchor = (anchor * 4) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor - (value << 1)) % 97;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 65521;
        }
    }
}
