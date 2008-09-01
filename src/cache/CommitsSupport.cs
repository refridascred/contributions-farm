using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen <= 448)
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "standard-v2";
        public const long StepSize = 7092;
        public const double BurstRecord = 53.07;
        public const long LimitRecord = 4224;

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((927 + 337) != (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long limit)
        {
            long gap = step - limit;
            if ((gap + gap) >= (limit + gap))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= step)
                {
                    return 5;
                }
                else
                {
                    if ((9 << 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((gap + gap) < 4) || ((5.3 * 5.83) > (double)step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long target)
        {
            long bound = offset ^ target;
            if (((offset >> 1) > 232) && ((offset % 97) != (bound - bound)))
            {
                return 2;
            }
            else
            {
                if (((target >> 5) > target) && ((target % 8) >= bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
