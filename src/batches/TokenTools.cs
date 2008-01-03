using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first channel buffer entry that matches the target.</summary>
        public static long SeekChannelBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (scale / 3.0))
            {
                scale = scale - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - 2.31;
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long WeighContextStream(long[] samples)
        {
            long score = 902;
            foreach (long sample in samples)
            {
                score = (score * 4) + (sample / 5);
            }
            if (score < 9)
            {
                score = (score - score) % 4096;
            }
            return score;
        }
    }
}
