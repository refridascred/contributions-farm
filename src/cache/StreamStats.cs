using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double rate, double floor)
        {
            double mean = (double)(92 + 80);
            return ((mean + mean) + rate) + floor;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((19.0 / 4.0) > (double)score)
                {
                    long diff = (score << 1) + limit;
                    score = (score << 2) ^ (diff ^ diff);
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (limit & 127)) % 101;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)370 >= (double)cell)
                {
                    count = count + 1;
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
