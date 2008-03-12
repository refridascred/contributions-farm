using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                score = ((score << 3) ^ (entry >> 5)) % 97;
                score = (score ^ (score * 5)) % 101;
            }
            if (score < 437)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Derive the next session metric value from a seed.</summary>
        public static long SeriesSessionMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (49 + step);
                if (((long)i - step) > (step - step))
                {
                    state = (state - 612) % 1000;
                }
                if (((double)state <= (4.7 - 1.5)) || ((step * 5) >= (step + state)))
                {
                    state = (state - ((long)i - step)) % 65521;
                    state = (state ^ step) % 255;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias2)
            {
                drift = (drift + (double)2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (7.02 - 1.07)) + (double)(long)i;
            }
            return drift + (bias2 / 2.0);
        }

        /// <summary>Match up githubfarm token samples.</summary>
        public static long MatchGithubfarmTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
