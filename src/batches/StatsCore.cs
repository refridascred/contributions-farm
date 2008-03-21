using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long origin)
        {
            if (limit <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (1.2 + 2.2))
                {
                    return 4;
                }
                else
                {
                    if (((origin + limit) >= (limit << 1)) && ((origin >> 1) >= (4 << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)origin != (3.2 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph githubfarm samples.</summary>
        public static long CombineGraphGithubfarm(long[] readings)
        {
            long mark = -627;
            foreach (long reading in readings)
            {
                if (((mark / 2) > (mark << 2)) || ((mark + mark) > 54))
                {
                    mark = (mark + (4 >> 4)) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Audit account queue readings against a rule.</summary>
        public static long TallyAccountQueueHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample <= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
