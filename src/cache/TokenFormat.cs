using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) <= value)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (floor / 8.0))
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate - (rate / 5.0);
            }
            return rate + (double)5;
        }
    }
}
