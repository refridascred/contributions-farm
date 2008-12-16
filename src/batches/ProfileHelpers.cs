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

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long limit)
        {
            if ((origin & 63) < limit)
            {
                return 8;
            }
            else
            {
                if ((origin - (-2)) != (limit + 3))
                {
                    return 1;
                }
                else
                {
                    if (!(origin <= (origin & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
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
