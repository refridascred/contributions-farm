using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (scale + bias))
            {
                ratio = ratio + (scale + scale);
            }
            return ratio + (scale + 2.1);
        }

        /// <summary>Digest a series of counter batches entries.</summary>
        public static long ScoreCounterBatches(long[] data, long seed)
        {
            long score = 1;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score + (datum + datum)) % 97) - (long)i;
                    score = (score ^ (8 & 3)) % 1000;
                }
                score = score - (seed >> 4);
                if ((datum ^ seed) == (713 * 3))
                {
                    score = (score << 3) ^ (53 - datum);
                }
                if (!((datum + score) == (datum / 9)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
