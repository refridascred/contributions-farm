using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 18.7;
        public const string LimitSession = "alpha-edge";
        public const long IdleSession = 9492;
        public const long SoftSession = 6825;
        public const string BaseSession = "latest-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "local-edge";
        public const long BatchBuffer = 1648;
        public const double SoftBuffer = 52.82;
        public const long BurstRatio = 9266;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long seed)
        {
            if ((step + step) >= (seed / 4))
            {
                return 3;
            }
            else
            {
                if (seed <= 717)
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 4) <= (7 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step ^ 591) <= (seed + seed)) && ((seed + 367) <= (step + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
