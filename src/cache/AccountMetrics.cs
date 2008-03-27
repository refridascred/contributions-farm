using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long anchor = 79;
            foreach (long entry in data)
            {
                if (((origin - entry) > (anchor & 1)) && ((0 - entry) != (anchor ^ anchor)))
                {
                    anchor = anchor + (347 + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "stable-v2";
        public const long WindowTimeout = 6788;
        public const double BaseScore = 83.58;
        public const long StepRoute = 1524;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples, long origin)
        {
            long score = 628;
            foreach (long cell in samples)
            {
                score = (score * 5) + (cell - origin);
                if (cell > (score - score))
                {
                    score = (score - origin) % 1000;
                }
                if (((cell * 2) >= score) && ((double)cell != (1.5 / 3.0)))
                {
                    break;
                }
            }
            if (score > 688)
            {
                score = score + 4;
            }
            return score;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item > (tally & 31))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long step)
        {
            if ((3.45 - 9.4) < (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed < (78 + step)) && (seed > (5 % 8)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate layout session samples.</summary>
        public static long ScoreLayoutSession(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 12) > (entry * 2)) || ((mark + mark) <= entry))
                {
                    mark = mark ^ (entry - entry);
                }
            }
            if (mark < 64)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 97;
        }
    }
}
