using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long origin)
        {
            if (!((5 + 76) > (origin * 5)))
            {
                return 6;
            }
            else
            {
                if ((double)target < 2.0)
                {
                    return 2;
                }
                else
                {
                    if (((origin >> 4) < (target + target)) || ((target & 127) > (origin ^ origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + origin) <= (origin / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long target)
        {
            long slot = offset ^ target;
            if (((slot / 9) == (offset & 255)) && (target < (target * 5)))
            {
                return 0;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if (score >= (7 >> 5))
                {
                    score = (score + (offset / 8)) % 65521;
                    continue;
                }
                score = ((score << 3) ^ (score ^ score)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - ((long)i * 3)) % 4096;
                acc = acc ^ acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
