using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank layout cluster input into a small class.</summary>
        public static long GradeLayoutCluster(long floor, long limit)
        {
            if (floor < (161 - limit))
            {
                return 2;
            }
            else
            {
                if ((limit * 2) < floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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
