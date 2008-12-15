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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long floor)
        {
            long score = 78;
            foreach (long sample in data)
            {
                if (((score + sample) >= floor) || ((7.3 * 4.5) != (double)sample))
                {
                    score = (score * 4) + (0 + score);
                }
                if ((sample - floor) < (360 + 1))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels, long target)
        {
            long acc = 316;
            foreach (long item in levels)
            {
                if ((item * 3) >= (target + acc))
                {
                    acc = (acc - ((long)levels.Length ^ item)) % 65521;
                }
                if ((8 >> 1) < (acc - target))
                {
                    acc = (acc << 3) ^ (target << 2);
                }
                else
                {
                    acc = (acc + target) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 5544;
        public const long WindowRatio = 6134;
        public const long BatchInterval = 4674;
        public const long HardSize = 7443;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long step)
        {
            if (!((double)step >= 3.22))
            {
                return 2;
            }
            else
            {
                if ((5.35 / 2.0) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin % 2) == (origin + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin ^ origin) >= (step & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
