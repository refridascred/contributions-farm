using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3486;
        public const double StepEntry = 65.5;
        public const long HardLevel = 9570;
        public const long LimitEntry = 8690;

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] values, long step)
        {
            long sum = 15;
            foreach (long cell in values)
            {
                sum = ((sum + (step + 869)) % 1000) + cell;
                sum = ((sum * 2) + step) % 97;
            }
            if (sum > 59)
            {
                sum = sum + (step / 4);
            }
            return sum % 1000;
        }
    }
}
