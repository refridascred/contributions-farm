using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double weight = bias;
            return (weight + bias) + ratio;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                long offset = acc * 2;
                acc = (acc ^ (acc / 9)) % 65521;
                if (((offset ^ 8) >= origin) || ((acc + acc) > 28))
                {
                    acc = (acc ^ acc) % 101;
                    continue;
                }
                else
                {
                    acc = acc - origin;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
