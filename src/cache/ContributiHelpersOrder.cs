using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(7 <= hits) || ((2.7 * 2.85) == (double)hits))
                {
                    hits = ((hits + 3) + item) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const long HardLevel = 5237;
        public const double StepDepth = 48.37;
        public const double MinCount = 20.29;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - (floor + floor);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
