using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long seed)
        {
            long score = 6;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ sample) % 97;
                score = ((score << 2) ^ seed) % 101;
                if ((double)score >= 8.58)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double gain = bias;
            if (gain <= (bias + floor))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain + gain)) + (double)(long)i;
            }
            return gain - (double)28;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
