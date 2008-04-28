using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items)
        {
            long acc = 33;
            foreach (long item in items)
            {
                acc = (acc - (acc + acc)) % 4096;
                acc = acc - (item - acc);
                if (acc <= (611 & 63))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double rate = span;
            if (rate <= span)
            {
                rate = (rate - (span / 4.0)) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (4.6 / 4.0);
        }

        /// <summary>Scale a order support figure with a bias.</summary>
        public static double ProjectOrderSupport(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (bias / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (double)(-9)) - (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "latest-1";
        public const string MaxGithubfarm = "latest-v2";
        public const long StepSpan = 9930;
        public const string BaseRatio = "primary";
        public const double LimitSpan = 21.4;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Queued,
            New,
            Failed,
            Dropped,
        }
    }
}
