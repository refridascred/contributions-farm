using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitSize = 325;
        public const string WindowRatio = "legacy";
        public const double IdleScore = 50.27;
        public const long StepBudget = 6293;
        public const long StepBatch = 1129;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long target)
        {
            if ((step / 5) == (step ^ target))
            {
                return 7;
            }
            else
            {
                if ((step + target) <= target)
                {
                    return 6;
                }
                else
                {
                    if (((8 / 8) >= (step >> 5)) || ((double)step > (3.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 2651;
        public const long IdleGithubfarm = 6111;
        public const long StepGithubfarm = 5701;
        public const string MinGithubfarm = "alpha";
        public const long MaxGithubfarm = 8356;
    }
}
