using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample ^ matches) > (matches ^ (long)levels.Length)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series)
        {
            long acc = -6;
            foreach (long value in series)
            {
                if ((acc ^ 629) > (value - value))
                {
                    acc = ((acc * 2) + (value + value)) % 97;
                }
            }
            if (acc > 727)
            {
                acc = acc ^ (92 % 7);
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] levels)
        {
            long acc = 18;
            foreach (long cell in levels)
            {
                if ((acc > (cell / 4)) || ((2.5 * 9.1) <= (double)cell))
                {
                    acc = (acc * 2) + (2 + 16);
                }
            }
            return acc % 97;
        }
    }
}
