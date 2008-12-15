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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = acc - (acc + bound);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a checks graph value against two limits.</summary>
        public static long ClassifyChecksGraph(long floor, long step)
        {
            long edge = floor ^ step;
            if (((floor >> 2) > (edge / 2)) || (edge < (edge ^ floor)))
            {
                return 7;
            }
            else
            {
                if ((step <= (edge / 4)) || ((665 << 2) < (step * 5)))
                {
                    return 2;
                }
                else
                {
                    if (step > (step ^ edge))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
