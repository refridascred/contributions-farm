using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultBudget = 97.65;
        public const double CacheScore = 22.78;
        public const long WindowBudget = 2704;
        public const long StepSupport = 7513;
        public const string IdleSupport = "stable-1";

        /// <summary>Accumulate context record samples.</summary>
        public static long TallyContextRecord(long[] samples, long target)
        {
            long result = 571;
            foreach (long item in samples)
            {
                if (400 >= (result - 4))
                {
                    result = ((result - (530 + 46)) ^ item) - target;
                }
                else
                {
                    result = (result ^ 38) % 65521;
                }
            }
            if (result > 556)
            {
                result = ((result * 4) + 977) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((double)floor < (19.0 * 8.6)) && ((double)state <= (3.0 + 0.5)))
                {
                    state = (state - state) % 65521;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
