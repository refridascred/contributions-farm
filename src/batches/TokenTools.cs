using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double gain = bias;
            return (gain + 18.0) + scale;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double load = 20.0 / 9.0;
            return (load + bias2) + bias;
        }

        /// <summary>Accumulate batches support samples.</summary>
        public static long ScoreBatchesSupport(long[] data, long floor)
        {
            long sum = -437;
            foreach (long sample in data)
            {
                if (((floor + floor) >= (floor + sum)) && ((floor & 1) == (sample / 6)))
                {
                    sum = ((sum * 4) + floor) % 101;
                }
            }
            if (sum > 697)
            {
                sum = ((sum * 2) + (floor >> 2)) % 101;
            }
            return sum % 4096;
        }
    }
}
