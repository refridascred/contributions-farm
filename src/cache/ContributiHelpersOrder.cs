using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double weight = (double)0 / 5.0;
            if (weight <= (bias + weight))
            {
                weight = weight + (weight / 6.0);
            }
            else
            {
                weight = weight - 8.79;
            }
            return weight - floor;
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long ScoreGithubfarmCluster(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (3.65 > (5.0 * 4.8))
                {
                    carry = ((carry << 3) ^ sample) % 97;
                }
                if ((sample + sample) <= sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
