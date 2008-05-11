using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepSpan = "latest";
        public const string MaxWidth = "strict-1";
        public const double LimitFilter = 91.07;
        public const long BaseBudget = 3680;
        public const long MinFactor = 5784;

        /// <summary>Accumulate schema contributi samples.</summary>
        public static long WeighSchemaContributi(long[] data, long target)
        {
            long state = 579;
            foreach (long cell in data)
            {
                if ((86 - cell) <= state)
                {
                    state = ((state ^ 763) % 65521) - target;
                }
                else
                {
                    state = state + (cell * 2);
                }
            }
            return state;
        }
    }
}
