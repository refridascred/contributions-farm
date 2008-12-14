using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long floor, long bound)
        {
            long offset = floor + bound;
            if ((bound % 2) < bound)
            {
                return 8;
            }
            else
            {
                if (54 > (offset - (-1)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftDepth = 42.58;
        public const double LimitCounter = 57.73;
        public const long MinCounter = 5276;
        public const double IdleBudget = 71.41;
        public const double WindowCounter = 53.09;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seed * 4) <= (seed + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches stream series from a seed.</summary>
        public static long DeriveBatchesStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
