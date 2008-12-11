using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = (weight + bias) + rate;
            }
            return weight - (bias / 5.0);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 3) + (state & 31);
                state = ((state * 2) + (state + state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine format session values into a single score.</summary>
        public static long WeighFormatSession(long[] data, long offset)
        {
            long sum = 853;
            foreach (long datum in data)
            {
                sum = (sum - (datum + sum)) % 101;
                if ((-22) <= (datum / 4))
                {
                    sum = sum + (2 + offset);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + offset) % 4096;
            }
            return sum;
        }
    }
}
