using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long bound)
        {
            long gap = limit + bound;
            if ((bound * 5) != (limit + bound))
            {
                return 6;
            }
            else
            {
                if ((double)gap != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((4.1 + 3.9) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
