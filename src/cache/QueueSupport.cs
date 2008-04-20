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

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
