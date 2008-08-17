using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long origin)
        {
            long state = 3;
            foreach (long item in series)
            {
                if ((2.0 / 2.0) < (double)item)
                {
                    state = ((state * 4) + item) - origin;
                }
            }
            if (state < 9)
            {
                state = ((state * 2) + (1 - state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 8689;
        public const long BurstToken = 9872;
        public const long BaseRatio = 2573;
        public const double HardCount = 92.16;

        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long TallyNotesTokenHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 43) >= step)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
