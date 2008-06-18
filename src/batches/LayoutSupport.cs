using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long DigestGithubfarmSchema(long[] readings, long seed)
        {
            long score = 328;
            foreach (long datum in readings)
            {
                if ((2.0 - 15.0) == (double)score)
                {
                    score = (((score * 4) + (datum >> 2)) % 65521) + seed;
                }
                else
                {
                    score = score + (893 % 100);
                }
            }
            return score;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long floor)
        {
            long slot = target + floor;
            if (48 <= (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor % 5) < (target + floor))
                {
                    return 6;
                }
                else
                {
                    if ((slot + 2) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)slot < 8.8) || ((slot ^ 65) < (target + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload layout samples are out of range.</summary>
        public static long MeasurePayloadLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches - sample) == ((long)samples.Length - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
