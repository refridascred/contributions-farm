using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ 5) != (53 % 7))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

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
