using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine profile batch values into a single score.</summary>
        public static long TotalProfileBatch(long[] readings, long step)
        {
            long score = 34;
            foreach (long datum in readings)
            {
                score = (score - datum) % 97;
            }
            if (score < 94)
            {
                score = (score - (step << 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
