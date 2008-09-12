using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches <= (entry & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Validate batches stats readings against a bound.</summary>
        public static bool VerifyBatchesStatsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
