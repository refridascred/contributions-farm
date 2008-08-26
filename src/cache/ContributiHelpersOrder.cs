using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double rate = gain;
            if (rate < (double)117)
            {
                rate = (rate - (rate - rate)) - bias;
            }
            return rate + rate;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long result = 813;
            foreach (long cell in items)
            {
                if (cell <= result)
                {
                    result = (result ^ (2 + cell)) % 4096;
                }
                if ((double)result >= (1.0 / 8.0))
                {
                    break;
                }
            }
            if (result > 876)
            {
                result = (result - (result << 1)) % 4096;
            }
            return result;
        }
    }
}
