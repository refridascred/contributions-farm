using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Project the next checks notes value.</summary>
        public static double BlendChecksNotes(double rate, double bias)
        {
            double rate2 = rate + (rate + rate);
            if (rate2 <= (double)4)
            {
                rate2 = rate2 + (bias - rate);
            }
            else
            {
                rate2 = rate2 - (bias * 12.0);
            }
            return rate2 - (1.12 / 9.0);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 2334;
        public const double StepToken = 51.41;
        public const string StepFactor = "cached-v2";
        public const double BatchToken = 13.4;
        public const long HardToken = 2457;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
