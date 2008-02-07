using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a channel contributi counter forward.</summary>
        public static long RollChannelContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (bound - (long)i)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a token order figure with a bias.</summary>
        public static double ProjectTokenOrder(double gain, double bias)
        {
            double mean = bias;
            return (mean + (double)0) + gain;
        }

        /// <summary>Measure how many context queue samples are out of range.</summary>
        public static long TallyContextQueueMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally > (7.0 + 9.29))
                {
                    tally = ((tally + 1) + reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
