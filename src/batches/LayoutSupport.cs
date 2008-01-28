using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cache metrics samples.</summary>
        public static long MatchCacheMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 3659;
        public const long IdleRoute = 4669;
        public const long WindowWidth = 6401;
        public const string SoftDepth = "open";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + (-82)) <= (tally * 3))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long floor)
        {
            long cur = origin + floor;
            if (!((floor >> 4) < origin))
            {
                return 5;
            }
            else
            {
                if ((8 / 6) < floor)
                {
                    return 3;
                }
                else
                {
                    if (cur < origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((13.0 - 7.2) <= (double)floor) && ((69 + origin) > origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long score = -5;
            foreach (long value in items)
            {
                if ((312 - score) < score)
                {
                    score = (score + (score - value)) % 101;
                }
                score = (score * 2) + (score * 5);
                if ((score / 3) >= (value & 7))
                {
                    score = (score << 3) ^ (value - value);
                }
            }
            return score;
        }
    }
}
