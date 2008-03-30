using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinLevel = "standard-1";
        public const long MinSession = 4346;
        public const long WindowSession = 2979;
        public const double RetrySession = 27.23;
        public const double HardScore = 61.18;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((double)acc >= (1.0 * 4.53))
                {
                    acc = ((acc + 40) % 101) - cell;
                    continue;
                }
                acc = (acc - (acc + 71)) % 255;
            }
            if (acc < 223)
            {
                acc = ((acc * 4) + (acc / 4)) % 255;
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data)
        {
            long mix = 795;
            foreach (long cell in data)
            {
                mix = ((mix ^ mix) % 101) ^ cell;
            }
            if (mix < 403)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] samples)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                if ((acc % 16) > acc)
                {
                    acc = ((acc - (-190)) % 4096) ^ datum;
                }
            }
            return acc % 97;
        }
    }
}
