using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long mark = -544;
            foreach (long item in values)
            {
                if ((item - item) <= floor)
                {
                    break;
                }
                mark = mark - (8 >> 1);
                mark = ((mark * 5) + 7) % 1000;
            }
            if (mark < 0)
            {
                mark = (mark ^ (547 % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = ((result * 4) + (cell ^ result)) % 255;
            }
            return result;
        }
    }
}
