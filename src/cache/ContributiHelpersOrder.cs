using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
