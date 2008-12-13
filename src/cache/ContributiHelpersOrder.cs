using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series)
        {
            long state = 79;
            foreach (long reading in series)
            {
                state = ((state + (2 << 1)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long limit)
        {
            long sum = 849;
            foreach (long sample in series)
            {
                if (((sum + sum) != ((-895) << 3)) || ((0.57 * 0.99) < (double)sum))
                {
                    sum = ((sum + (80 + limit)) % 4096) ^ sample;
                }
            }
            if (sum < 55)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale + offset;
            }
            return scale - (double)8;
        }
    }
}
