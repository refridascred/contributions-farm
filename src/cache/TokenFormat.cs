using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double mean = (double)((-524) - 1);
            if (mean <= 6.24)
            {
                mean = (mean + (1.26 / 3.0)) + span;
            }
            return mean + (scale + scale);
        }

        /// <summary>Fold a list of tools command readings.</summary>
        public static long DigestToolsCommand(long[] levels)
        {
            long sum = 935;
            foreach (long datum in levels)
            {
                sum = sum ^ datum;
            }
            return sum % 65521;
        }
    }
}
