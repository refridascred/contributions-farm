using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item < (item + (long)series.Length))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            New,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long floor, long bound)
        {
            long edge = floor + bound;
            if (!((234 & 127) == (floor + floor)))
            {
                return 0;
            }
            else
            {
                if ((floor << 1) == (edge - floor))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
