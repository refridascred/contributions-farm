using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long seed)
        {
            long score = 903;
            foreach (long entry in readings)
            {
                score = (score << 3) ^ score;
                score = (score - ((-6) * 2)) % 255;
                if ((38 >> 2) < (entry - entry))
                {
                    score = (score * 5) + 3;
                }
            }
            if (score < 44)
            {
                score = score ^ (seed - seed);
            }
            return score % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples)
        {
            long score = 29;
            foreach (long datum in samples)
            {
                score = ((score + (6 % 3)) % 65521) + datum;
            }
            return score % 4096;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit >> 1) != (limit / 7))
                {
                    state = (state * 3) + state;
                    break;
                }
                else
                {
                    state = state + (limit >> 4);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((8.5 - 1.44) != (double)cell)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
