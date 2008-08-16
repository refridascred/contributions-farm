using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - item) < matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long offset)
        {
            long step = floor - offset;
            if ((floor * 4) == (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (3.9 + 2.51))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
