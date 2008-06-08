using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 8507;
        public const double MaxPayload = 95.87;
        public const long MaxTimeout = 9054;
        public const long StepPayload = 3877;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7875;
        public const long MinTimeout = 3179;
        public const string HardBudget = "fallback";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits <= 4.0)
                {
                    hits = ((hits + 1) + item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a profile support pair into a bucket.</summary>
        public static long GradeProfileSupport(long limit, long origin)
        {
            long edge = limit + origin;
            if ((origin ^ origin) < (origin + origin))
            {
                return 6;
            }
            else
            {
                if (edge < (limit ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 > (double)origin) || ((limit % 3) <= (6 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - ((long)i - mix)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
