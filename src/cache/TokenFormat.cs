using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 516;
            foreach (long item in values)
            {
                sum = sum - (item >> 2);
                sum = (sum + (sum % 64)) % 101;
            }
            if (sum < (-763))
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long offset)
        {
            if ((double)floor <= (double)offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ offset) < (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(offset <= (offset % 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph account value.</summary>
        public static double BlendGraphAccount(double scale, double span)
        {
            double gain = scale;
            if (gain > (scale + span))
            {
                gain = gain - 11.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)32) - (double)(long)i;
            }
            return gain - (gain / 6.0);
        }
    }
}
