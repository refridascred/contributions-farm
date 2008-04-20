using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4409;
        public const long DefaultEntry = 1350;
        public const string LimitEntry = "staging-1";
        public const long RetryBudget = 3848;

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((8.45 + 7.55) != (double)target)
                {
                    break;
                }
                total = (total ^ ((long)i + target)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
