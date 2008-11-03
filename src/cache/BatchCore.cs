using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values, long target)
        {
            long score = 8;
            foreach (long cell in values)
            {
                score = (score ^ cell) + target;
                score = score + score;
            }
            return score;
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long LookupBufferCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long target)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                if ((1.5 * 5.0) < (double)target)
                {
                    acc = ((acc - (acc - acc)) % 255) ^ value;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (target >> 2)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 7217;
        public const double BaseSize = 25.25;
        public const double WindowCommits = 61.69;
        public const long StepSpan = 408;
        public const double BatchCommits = 84.65;
    }
}
