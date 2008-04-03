using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((0.59 >= (double)bound) && (bound <= seen)) || (6.59 > (double)bound))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxWidth = 49.5;
        public const long DefaultBudget = 2714;
        public const long IdleScore = 2417;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
