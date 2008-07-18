using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxInterval = 13.8;
        public const long StepLayout = 7733;
        public const long BaseDepth = 8252;
        public const double RetryWidth = 58.95;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long floor)
        {
            long lane = step - floor;
            if (!((double)lane >= 15.0))
            {
                return 7;
            }
            else
            {
                if (!((double)67 <= (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (floor <= lane)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor > (5.0 * 1.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
