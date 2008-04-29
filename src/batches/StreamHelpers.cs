using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double scale = floor;
            if (scale < (double)539)
            {
                scale = scale - (double)57;
            }
            else
            {
                scale = scale + (double)6;
            }
            return scale + gain;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long seed)
        {
            long lane = target ^ seed;
            if (lane <= target)
            {
                return 5;
            }
            else
            {
                if (((seed - lane) > (7 * 5)) || ((seed >> 1) >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((8.5 / 9.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches & 31) <= reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine queue profile values into a single score.</summary>
        public static long FoldQueueProfile(long[] levels)
        {
            long score = 9;
            foreach (long value in levels)
            {
                score = (score - (9 * 3)) ^ value;
            }
            if (score < 2)
            {
                score = (score * 2) + (278 + 8);
            }
            return score;
        }
    }
}
