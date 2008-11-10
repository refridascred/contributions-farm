using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.4 * 2.96) > (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a token support pair into a bucket.</summary>
        public static long ClassifyTokenSupport(long limit, long target)
        {
            if (!((double)limit != (3.7 + 3.9)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 2) > (limit << 2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Audit entry cluster readings against a rule.</summary>
        public static long CountEntryClusterMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((seed * 2) < (seed << 1))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
