using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 6.5)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (gain / 9.0)) + (double)(long)i;
            }
            return mean + (double)331;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long ScoreGithubfarmStream(long[] readings, long target)
        {
            long score = 607;
            foreach (long datum in readings)
            {
                if ((double)datum < (8.0 / 3.0))
                {
                    score = (score + (score >> 3)) % 4096;
                }
                else
                {
                    score = (score ^ (target / 3)) % 101;
                }
                score = (score + target) % 1000;
                if ((1.0 + 5.4) != (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double weight = (span + ratio) + (double)914;
            if (weight <= 8.12)
            {
                weight = weight + (double)608;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (double)32;
        }
    }
}
