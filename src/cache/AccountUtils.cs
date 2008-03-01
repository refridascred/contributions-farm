using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((floor + 84) > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((floor + 48) < (limit >> 1)) && ((double)12 == (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetrySpan = 75.46;
        public const string DefaultNotes = "alpha";
        public const long DefaultLevel = 6901;
        public const string BatchNotes = "strict-1";
        public const long StepRatio = 8890;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings, long target)
        {
            long mix = 61;
            foreach (long value in readings)
            {
                mix = ((mix - mix) ^ value) - target;
            }
            return mix;
        }
    }
}
