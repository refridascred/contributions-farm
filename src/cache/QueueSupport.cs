using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 2011;
        public const long StepToken = 1311;
        public const long MinBudget = 5989;
        public const long LimitToken = 671;
        public const long StepWidth = 9605;

        /// <summary>Grade a command commits value against two limits.</summary>
        public static long SortCommandCommits(long floor, long seed)
        {
            if ((51 / 5) <= floor)
            {
                return 2;
            }
            else
            {
                if ((floor & 63) > 519)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
