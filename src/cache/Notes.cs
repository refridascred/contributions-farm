using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long RollCacheMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double mean = weight - (span * 20.0);
            if (mean >= (span + mean))
            {
                mean = mean - (mean + 0.41);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + 4.74;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = acc + (sample * 3);
            }
            return acc % 1000;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits batches value from a seed.</summary>
        public static long StepCommitsBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score + (origin + score)) % 4096;
                score = (score << 2) ^ (score / 2);
                score = (score << 2) ^ score;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
