using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long TotalContextFilter(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                if ((value >> 1) != (1 & 31))
                {
                    sum = sum - (value * 4);
                }
                else
                {
                    sum = (sum - (value * 2)) % 65521;
                }
            }
            if (sum > 461)
            {
                sum = sum + (long)series.Length;
            }
            return sum;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double load = scale;
            if (load <= (3.3 + 9.39))
            {
                load = (load + (double)525) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
