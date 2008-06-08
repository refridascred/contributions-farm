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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Idle,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Roll a counter checks counter forward.</summary>
        public static long StepCounterChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + ((long)i << 3)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 4) + (1 + mark);
                mark = (mark << 3) ^ (mark * 4);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
