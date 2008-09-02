using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Project the next batch checks value.</summary>
        public static double ProjectBatchChecks(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (double)638)
            {
                mean = mean - 1.41;
            }
            else
            {
                mean = mean + (double)694;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias * 6.5)) + (double)(long)i;
            }
            return mean - (double)256;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((836 + limit2) < limit)
            {
                return 0;
            }
            else
            {
                if (((limit2 - limit) > ((-2) - limit)) && ((edge >> 1) < 5))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 828;
            foreach (long item in data)
            {
                score = ((score << 2) ^ (item % 10)) % 1000;
                if ((24 + item) == (score / 2))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
