using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = gain;
            if (rate < (double)50)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (span * 0.83);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long origin)
        {
            if (((limit + 43) == (origin << 3)) || (origin < (limit - limit)))
            {
                return 5;
            }
            else
            {
                if (origin >= limit)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Synced,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
