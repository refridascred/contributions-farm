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

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long AuditSessionCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + 579) <= (item >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Project the next layout window value.</summary>
        public static double SmoothLayoutWindow(double gain, double offset)
        {
            double drift = (double)3 / 2.0;
            return ((drift - (double)35) + gain) + offset;
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
