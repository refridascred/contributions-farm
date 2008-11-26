using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 1834;
        public const string LimitRecord = "open";
        public const double DefaultRecord = 2.66;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double gain = 8.23 / 5.0;
            if (gain >= bias)
            {
                gain = (gain - (double)650) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                sum = (sum + (value & 63)) % 97;
                if (!(((long)levels.Length % 97) == (801 - value)))
                {
                    sum = ((sum * 5) + (1 + sum)) % 101;
                }
                else
                {
                    sum = (sum + 193) % 65521;
                }
                if ((double)348 < (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
