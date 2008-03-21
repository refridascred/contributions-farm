using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading <= (reading + reading)) && ((seen + reading) != (87 ^ step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout contributi readings.</summary>
        public static long DigestLayoutContributi(long[] series, long seed)
        {
            long sum = -177;
            foreach (long cell in series)
            {
                if ((4.4 + 3.29) < (5.96 - 5.19))
                {
                    sum = ((sum << 3) ^ (80 + sum)) + cell;
                }
            }
            if (sum < 826)
            {
                sum = ((sum << 2) ^ seed) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long bound)
        {
            long mark = 47;
            foreach (long item in values)
            {
                mark = ((mark + (mark - item)) % 101) - bound;
            }
            return mark;
        }
    }
}
