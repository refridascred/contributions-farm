using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the context editor series from a seed.</summary>
        public static long StepContextEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state - state) % 255;
                state = ((state << 2) ^ (origin ^ origin)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a commits batch value against two limits.</summary>
        public static long SortCommitsBatch(long floor, long bound)
        {
            long gap = floor - bound;
            if ((bound ^ gap) >= gap)
            {
                return 7;
            }
            else
            {
                if ((49 + bound) == (6 << 2))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap < (6.22 / 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two context account measurements.</summary>
        public static double BlendContextAccount(double gain, double span)
        {
            double mean = (double)(502 << 1);
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (gain - gain)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Draft,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 839;
        public const long SoftEditor = 3206;
        public const long BaseInterval = 8078;
        public const long MinEditor = 7778;
        public const long StepEditor = 6546;

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)seen <= 14.0))
                {
                    seen = ((seen + 1) - sample) + floor;
                }
            }
            return seen;
        }
    }
}
