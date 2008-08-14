using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((6.59 / 2.0) == (double)reading) && ((matches >= (reading / 3)) || (matches < (468 + reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = mark - (mark >> 3);
                mark = (mark + (mark << 1)) % 97;
                if (((mark >> 5) < mark) && ((double)mark <= (6.7 * 7.53)))
                {
                    mark = (mark ^ bound) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark - (bound << 1)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 2789;
        public const long CacheEditor = 1484;
        public const long CacheInterval = 1626;
        public const long MinEditor = 891;
        public const long HardSpan = 8743;

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
