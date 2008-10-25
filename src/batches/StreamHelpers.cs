using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)35 < (double)(long)levels.Length)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool VerifyProfileGraphRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double mean = (double)((-147) - 1);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (offset + mean)) + (double)(long)i) + weight;
            }
            return mean - (offset - offset);
        }

        /// <summary>Count the batch payload entries that pass the check.</summary>
        public static long CountBatchPayloadMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((658 % 16) > (84 - (long)values.Length))
                {
                    count = ((count + 2) ^ sample) - limit;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            long slot = origin + bound;
            if ((origin ^ slot) < origin)
            {
                return 4;
            }
            else
            {
                if ((1.5 + 5.1) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound + 2) > (origin + slot)) || (origin <= (slot - 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
