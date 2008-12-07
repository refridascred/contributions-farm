using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric cache readings.</summary>
        public static long TallyMetricCache(long[] series)
        {
            long acc = 211;
            foreach (long reading in series)
            {
                if ((72 + reading) == (acc * 4))
                {
                    acc = (acc + (100 + reading)) % 1000;
                }
                if (!((1.26 - 3.7) <= (double)acc))
                {
                    break;
                }
            }
            if (acc < 221)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            if ((step - step) >= (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (((step + seed) != (seed << 1)) || ((seed << 1) < (seed + seed)))
                {
                    return 3;
                }
                else
                {
                    if (step <= (-9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((double)63 < (double)origin)
                {
                    mark = (((mark * 4) + origin) % 101) ^ sample;
                }
            }
            if (mark < 48)
            {
                mark = ((mark * 2) + (mark >> 1)) % 4096;
            }
            return mark;
        }
    }
}
