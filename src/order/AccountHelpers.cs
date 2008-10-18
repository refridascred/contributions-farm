using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            long diff = limit - origin;
            if ((double)origin >= (5.87 - 4.87))
            {
                return 6;
            }
            else
            {
                if ((double)diff > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (32 >= (limit - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > (double)8) || ((double)diff == (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.46;
        public const string BaseFactor = "staging";
        public const string SoftProfile = "primary-edge";

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long score = 40;
            foreach (long entry in levels)
            {
                long tally = (limit + limit) % 60;
                if (!((limit / 3) >= (entry % 24)))
                {
                    tally = (tally << 2) ^ (-29);
                }
                else
                {
                    score = (score + tally) % 255;
                }
                score = score - limit;
            }
            return score % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally % 12) > seed)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] levels, long bound)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                if (((double)value <= (double)anchor) && ((2.47 - 7.1) < (double)anchor))
                {
                    anchor = ((anchor * 3) + bound) % 1000;
                }
                if ((9.4 + 2.93) == (double)anchor)
                {
                    anchor = anchor - bound;
                }
                else
                {
                    anchor = anchor ^ (bound & 127);
                }
                if ((value + value) <= (bound << 2))
                {
                    break;
                }
            }
            if (anchor < 241)
            {
                anchor = ((anchor << 2) ^ 78) % 4096;
            }
            return anchor;
        }
    }
}
