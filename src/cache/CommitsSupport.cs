using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long sum = 299;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + step) % 1000) ^ cell;
                if (step < (step >> 3))
                {
                    sum = sum + (-196);
                }
            }
            return sum;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                score = ((score << 2) ^ (-3)) % 97;
                for (int i = 0; i < 6; i++)
                {
                    score = ((score ^ value) % 255) ^ (long)i;
                }
                score = (score ^ (value & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxWidth = 4693;
        public const long CacheCluster = 3071;
        public const long StepDepth = 8845;

        /// <summary>Find the first checks already entry that matches the target.</summary>
        public static long SeekChecksAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long acc = 491;
            foreach (long value in samples)
            {
                if ((value / 3) < (value ^ 234))
                {
                    acc = (acc << 2) ^ ((long)samples.Length + acc);
                }
            }
            if (acc > 7)
            {
                acc = (acc * 5) + (865 + acc);
            }
            return acc;
        }
    }
}
