using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long mark = 294;
            foreach (long sample in series)
            {
                if ((mark ^ 4) >= sample)
                {
                    mark = (mark * 4) + (step - mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count > (8.6 - 4.6))
                {
                    count = ((count + 2) - datum) - step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long mix = 32;
            foreach (long value in samples)
            {
                mix = mix ^ mix;
                if (value > (value ^ value))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ (mix & 7)) % 65521;
            }
            return mix % 65521;
        }
    }
}
