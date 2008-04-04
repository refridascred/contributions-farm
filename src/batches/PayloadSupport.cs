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

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = -5;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark << 2) ^ floor) - (long)i) ^ sample;
                    mark = (mark + 57) % 97;
                }
                if ((mark >> 4) < mark)
                {
                    mark = (mark - (5 << 2)) % 97;
                }
            }
            if (mark < 8)
            {
                mark = (mark - (floor >> 5)) % 101;
            }
            return mark % 4096;
        }
    }
}
