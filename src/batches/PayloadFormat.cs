using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen + seen) <= (entry ^ entry)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            if (offset < (floor + floor))
            {
                return 1;
            }
            else
            {
                if (485 < (floor >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) >= (236 % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - 868) < (floor - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double offset)
        {
            double mean = 4.7 + (ratio - ratio);
            if (mean < ratio)
            {
                mean = mean - (offset * 2.2);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + (6.21 - mean);
        }
    }
}
