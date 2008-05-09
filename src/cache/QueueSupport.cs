using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a layout tools counter forward.</summary>
        public static long IterateLayoutTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!((state - 974) == (floor & 31)))
                {
                    state = ((state * 5) + ((long)i & 15)) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the counter account entries that pass the check.</summary>
        public static long MeasureCounterAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseWidth = "legacy";
        public const long MinScore = 1401;
        public const string SoftFilter = "staging-v2";
    }
}
