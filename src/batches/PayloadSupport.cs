using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data, long floor)
        {
            long sum = 0;
            foreach (long sample in data)
            {
                if (!((floor * 5) <= (sum + sum)))
                {
                    sum = (((sum * 3) + (floor / 3)) % 97) ^ sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 9099;
        public const long MaxWindow = 1643;
        public const long HardDepth = 8092;
        public const double DefaultWidth = 58.88;

        /// <summary>Scale a githubfarm token figure with a bias.</summary>
        public static double ProjectGithubfarmToken(double rate, double bias)
        {
            double weight = bias + (rate / 9.0);
            if (weight <= bias)
            {
                weight = weight + (double)90;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)8;
        }
    }
}
