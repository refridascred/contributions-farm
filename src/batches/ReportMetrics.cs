using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a contributi report pair into a bucket.</summary>
        public static long RankContributiReport(long seed, long step)
        {
            long span = seed + step;
            if ((678 << 3) == (seed ^ step))
            {
                return 6;
            }
            else
            {
                if (!((double)span < (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed + span) != (step - 700))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed >= (double)812)
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
    }
}
