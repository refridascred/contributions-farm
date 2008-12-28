using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 14.0;
        public const long StepAlready = 8377;
        public const string RetryDepth = "legacy-1";
        public const long SoftAlready = 4416;

        /// <summary>Accumulate report buffer samples.</summary>
        public static long ScoreReportBuffer(long[] series)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (sum - (sample + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up editor already samples.</summary>
        public static long MatchEditorAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
