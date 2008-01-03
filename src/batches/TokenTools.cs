using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long seed)
        {
            if ((double)seed < (double)target)
            {
                return 2;
            }
            else
            {
                if ((seed & 1) <= (target * 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (7.38 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed >= (7.91 + 3.3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
