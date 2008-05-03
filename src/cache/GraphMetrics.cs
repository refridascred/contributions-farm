using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9430;
        public const string IdleLevel = "primary-1";
        public const long MaxProfile = 8850;
        public const string SoftProfile = "alpha-edge";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((score + score) <= sample)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 17)
            {
                score = (score - (score - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next profile tools value.</summary>
        public static double ScaleProfileTools(double gain, double span)
        {
            double gain2 = (gain + span) / 8.0;
            if (gain2 >= (span + gain2))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (3.53 * 3.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - span) - (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
