using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long target)
        {
            long diff = limit + target;
            if ((diff * 4) < (target + target))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (limit < (limit - 34))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target & 7) > 18)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((296 * 4) <= datum)
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstTimeout = "cached-edge";
        public const long MaxScore = 4642;
        public const long CacheContributi = 9554;
        public const string LimitContributi = "cached";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long offset)
        {
            if (((double)offset < (double)step) && (offset > (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((step - offset) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinRatio = 65.17;
        public const long StepRatio = 7445;
        public const double DefaultLevel = 69.18;
    }
}
