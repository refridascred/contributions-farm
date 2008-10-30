using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the batch already series from a seed.</summary>
        public static long RollBatchAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + (long)i) == ((long)i + limit))
                {
                    carry = carry - 0;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 4928;
        public const double IdleTimeout = 66.08;
        public const string CacheBatch = "fallback-1";
        public const string RetryBatch = "local-edge";
        public const long SoftBatch = 1949;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9863;
        public const long BurstFilter = 7299;
        public const long HardFilter = 6671;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
