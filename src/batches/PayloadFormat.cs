using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a checks support value against two limits.</summary>
        public static long BucketChecksSupport(long offset, long step)
        {
            if ((double)step <= 2.7)
            {
                return 7;
            }
            else
            {
                if (step > (95 + step))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 2) >= (89 % 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 2) <= (step & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
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
