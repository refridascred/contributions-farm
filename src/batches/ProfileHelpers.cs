using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every account channel entry stays within the limit.</summary>
        public static bool CheckAccountChannelBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double load = (double)(251 - 502);
            for (int i = 0; i < 5; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (rate + 9.2);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long limit)
        {
            long sum = 26;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sample + sample)) % 255) - limit;
            }
            return sum % 1000;
        }
    }
}
