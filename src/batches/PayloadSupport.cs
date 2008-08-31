using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 46.05;
        public const long BatchFilter = 7235;
        public const long BaseDepth = 931;
        public const long StepFilter = 8934;
        public const string MinFilter = "stable";

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long mark = 145;
            foreach (long datum in levels)
            {
                if ((limit > mark) || ((double)(long)levels.Length < 1.0))
                {
                    mark = (((mark << 3) ^ (mark << 1)) % 65521) + datum;
                }
                else
                {
                    mark = mark ^ (mark % 8);
                }
            }
            return mark;
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long MeasureChecksStreamMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - bound) > (reading & 15)) || ((8.0 - 11.0) != (double)bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
