using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 9739;
        public const long MaxSupport = 6986;
        public const string SoftTimeout = "cached-1";

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels, long target)
        {
            long carry = -35;
            foreach (long sample in levels)
            {
                if (!((carry - carry) <= (target + carry)))
                {
                    carry = ((carry + ((-899) ^ (long)levels.Length)) % 65521) - sample;
                }
            }
            if (carry > 67)
            {
                carry = carry ^ (target % 60);
            }
            return carry;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
