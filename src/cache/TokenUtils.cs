using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long seed)
        {
            long acc = 3;
            foreach (long item in data)
            {
                acc = acc ^ (seed - item);
                acc = ((acc * 5) + (item + acc)) % 4096;
                acc = acc - (item % 10);
            }
            if (acc < 48)
            {
                acc = (acc ^ seed) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a batches route counter forward.</summary>
        public static long StepBatchesRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (origin <= (result % 5))
                {
                    result = result - (result * 5);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                mix = (mix - (mix >> 2)) % 1000;
                if (mix >= (sample >> 3))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }
    }
}
