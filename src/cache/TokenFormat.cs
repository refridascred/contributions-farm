using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 6841;
        public const double SoftTimeout = 2.83;
        public const double LimitWindow = 28.42;
        public const long SoftRatio = 2146;
        public const long StepBudget = 799;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long bound)
        {
            long span = step + bound;
            if ((6 / 3) <= span)
            {
                return 7;
            }
            else
            {
                if ((2 % 3) != (bound / 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) < (tally + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
