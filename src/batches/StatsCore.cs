using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up schema layout samples.</summary>
        public static long OverlapSchemaLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            long cur = origin + target;
            if (origin <= target)
            {
                return 2;
            }
            else
            {
                if ((double)origin < (double)85)
                {
                    return 0;
                }
                else
                {
                    if ((47 + origin) < (origin ^ 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target / 3) >= (cur - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((offset + span) > (844 + floor))
            {
                return 3;
            }
            else
            {
                if (floor <= offset)
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 3.0) > (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a batch counter value against two limits.</summary>
        public static long RankBatchCounter(long step, long limit)
        {
            long step2 = step - limit;
            if ((double)step2 <= (1.6 - 1.9))
            {
                return 8;
            }
            else
            {
                if ((step & 15) >= limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long offset)
        {
            if (!((double)6 < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) < (offset - offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
