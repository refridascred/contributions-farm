using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 82.64;
        public const long IdleCount = 5125;
        public const long RetryNotes = 8457;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (47 - 47)) % 97;
                state = ((state << 2) ^ (state - target)) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long FoldClusterMetric(long[] series)
        {
            long acc = 703;
            foreach (long item in series)
            {
                acc = ((acc * 2) + (item + item)) % 1000;
                if ((acc + item) > (item + acc))
                {
                    acc = (acc ^ (acc % 97)) % 255;
                }
            }
            if (acc < 785)
            {
                acc = ((acc * 5) + (acc - acc)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 2) ^ ((long)i % 3);
                state = state + (state - bound);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
