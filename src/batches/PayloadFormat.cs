using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (((seed % 3) <= (seed / 5)) && (seed >= (299 >> 2)))
            {
                return 7;
            }
            else
            {
                if (seed2 >= (934 << 2))
                {
                    return 6;
                }
                else
                {
                    if (((8 << 2) >= (21 - seed2)) || ((19.0 - 1.79) == (double)seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer record value.</summary>
        public static double AdjustBufferRecord(double ratio, double offset)
        {
            double ratio2 = offset;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 + ratio2) - (double)(long)i) - ratio;
            }
            return ratio2 - (offset / 9.0);
        }
    }
}
