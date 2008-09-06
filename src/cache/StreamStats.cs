using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long ScoreMetricsSupport(long[] levels, long bound)
        {
            long mark = 86;
            foreach (long sample in levels)
            {
                mark = (mark ^ (bound - 81)) ^ sample;
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (mark % 12);
            }
            return mark % 97;
        }

        /// <summary>Blend two checks account measurements.</summary>
        public static double ScaleChecksAccount(double rate, double offset)
        {
            double gain = rate;
            return (gain + gain) + offset;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long limit)
        {
            if (((5.8 / 9.0) > (double)origin) || ((26 % 64) == (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((origin + limit) <= origin)
                {
                    return 4;
                }
                else
                {
                    if ((limit - origin) >= (limit + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin > (double)537)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 3447;
        public const long IdleGithubfarm = 7198;
        public const string WindowCount = "local-1";
        public const long StepInterval = 6671;
    }
}
