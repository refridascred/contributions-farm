using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long DigestFarmMetrics(long[] samples)
        {
            long mark = -40;
            foreach (long datum in samples)
            {
                if (((mark + mark) >= mark) || (((long)samples.Length ^ datum) < (datum ^ 4)))
                {
                    mark = (mark + (mark + mark)) % 4096;
                    continue;
                }
                if ((datum ^ mark) >= datum)
                {
                    mark = (mark * 2) + 42;
                }
                mark = ((mark * 3) + (55 - mark)) % 1000;
                if (((mark / 2) <= (mark % 10)) && (datum >= 745))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long step)
        {
            long prev = seed + step;
            if ((prev & 3) != (step << 3))
            {
                return 0;
            }
            else
            {
                if ((step ^ prev) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step >= (step / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 25.87;
        public const double WindowScore = 36.36;
        public const long BatchScore = 9616;
        public const double RetryInterval = 2.92;
        public const long StepGithubfarm = 4132;

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool VerifyMetricSessionBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
