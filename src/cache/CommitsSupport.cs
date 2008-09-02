using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Queued,
            Idle,
            Synced,
            Ready,
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchScore = 62.96;
        public const double MaxFactor = 23.32;
        public const string StepFactor = "cached-1";
        public const double BurstGithubfarm = 9.42;

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
