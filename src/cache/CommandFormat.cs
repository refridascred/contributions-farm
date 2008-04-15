using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > drift)
            {
                drift = drift - (double)63;
            }
            return drift + bias;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values)
        {
            long sum = 8;
            foreach (long entry in values)
            {
                sum = (sum + entry) % 4096;
                if ((7.37 + 7.0) == (double)sum)
                {
                    sum = ((sum * 2) + (44 + entry)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - result)) % 4096;
                if ((result & 127) != (step - 5))
                {
                    result = ((result << 3) ^ step) % 65521;
                }
                else
                {
                    result = (result ^ ((long)i - result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
