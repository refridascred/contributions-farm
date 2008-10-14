using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long floor)
        {
            if (offset > 861)
            {
                return 5;
            }
            else
            {
                if (6.3 <= (2.8 - 2.6))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 15) <= (floor + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((417 ^ floor) > (floor + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream context measurements.</summary>
        public static double ScaleStreamContext(double rate, double floor)
        {
            double rate2 = (floor / 3.0) - floor;
            if (rate2 <= (floor / 4.0))
            {
                rate2 = (rate2 - rate2) + rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 2) <= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
