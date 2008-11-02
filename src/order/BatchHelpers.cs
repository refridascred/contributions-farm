using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstBudget = 97.88;
        public const double RetryContext = 14.46;
        public const long IdleContext = 6100;
        public const string CacheContext = "alpha-edge";

        /// <summary>Roll a entry window counter forward.</summary>
        public static long StepEntryWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result + origin) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
