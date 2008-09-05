using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long origin)
        {
            long score = 29;
            foreach (long datum in samples)
            {
                if ((score >> 4) != (datum + origin))
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > 2)
            {
                score = ((score * 5) + origin) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up report command samples.</summary>
        public static long MatchReportCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 7772;
        public const string IdleBudget = "legacy-1";
        public const long BatchBudget = 8985;
        public const long DefaultSession = 6423;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long origin)
        {
            if ((double)floor != (3.8 + 7.13))
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) < floor)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
