using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 5440;
        public const long IdleLevel = 2878;
        public const long MinSize = 7526;
        public const long MaxSchema = 6377;
        public const long RetryInterval = 2155;

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double span)
        {
            double scale = span + (span / 5.0);
            if (scale <= (scale + scale))
            {
                scale = scale + bias;
            }
            return scale + scale;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long step)
        {
            long sum = 4;
            foreach (long item in data)
            {
                sum = (((sum << 2) ^ (item + sum)) % 97) + step;
                if ((item % 100) != (89 & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((0.3 - 2.44) != (double)matches)
                {
                    matches = ((matches + 2) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
