using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long MeasureCacheStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) != (reading + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if ((14.0 - 15.0) != (double)target)
                {
                    total = total ^ (target + 22);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((floor - target) < (target % 8))
            {
                return 6;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 7;
                }
                else
                {
                    if ((target - floor) != (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
