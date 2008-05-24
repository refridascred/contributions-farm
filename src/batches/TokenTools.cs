using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinBudget = 71.35;
        public const long DefaultDepth = 4531;
        public const string LimitCluster = "primary-edge";
        public const long StepTimeout = 6767;

        /// <summary>Find the first tools entry entry that matches the target.</summary>
        public static long SeekToolsEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= (count - reading))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
