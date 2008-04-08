using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long target, long limit)
        {
            if ((target << 1) >= (target + target))
            {
                return 3;
            }
            else
            {
                if (limit < target)
                {
                    return 4;
                }
                else
                {
                    if (((target - limit) > (limit + 56)) || ((target ^ limit) == (limit + 917)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit != (0.13 * 6.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long sum = -34;
            foreach (long sample in levels)
            {
                sum = ((sum * 3) + sample) % 4096;
                sum = sum ^ (floor - sample);
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!!((double)bound <= (9.0 / 6.0)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
