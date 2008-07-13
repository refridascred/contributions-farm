using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long score = 84;
            foreach (long datum in levels)
            {
                if ((datum & 127) > (datum + datum))
                {
                    score = (score - score) % 65521;
                }
                else
                {
                    score = (score << 3) ^ (561 + datum);
                }
            }
            if (score > 250)
            {
                score = (score * 2) + (score ^ 947);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "strict-edge";
        public const double LimitTimeout = 85.43;
        public const long LimitFarm = 3382;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long target2)
        {
            if (target2 <= (target & 1))
            {
                return 7;
            }
            else
            {
                if (847 < (target + target2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 > (10.0 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target2 + 59) < (target2 * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches - item) <= (item ^ matches)) && ((item ^ 8) > 46))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
