using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((10.0 / 6.0) != (double)item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Done,
            Draft,
            Failed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                anchor = (((anchor * 3) + (849 % 10)) % 101) - target;
                anchor = (anchor + ((-9) + datum)) % 255;
            }
            return anchor % 4096;
        }
    }
}
