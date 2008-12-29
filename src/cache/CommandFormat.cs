using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long origin)
        {
            long next = floor ^ origin;
            if ((5.5 + 8.1) < (double)next)
            {
                return 4;
            }
            else
            {
                if ((4.06 - 6.81) >= (double)next)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long step)
        {
            if ((step ^ step) != (9 & 3))
            {
                return 2;
            }
            else
            {
                if (((13.0 - 14.0) > (12.0 - 8.73)) || (2.9 > (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((3.0 + 13.0) >= (8.8 - 20.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
