using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Done,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long MeasureCommitsFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((-1) < (seen ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string HardTimeout = "alpha";
        public const long BaseSize = 3201;
        public const double SoftTimeout = 84.47;
        public const string BurstChannel = "stable-edge";

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long origin2)
        {
            if (origin2 < origin)
            {
                return 1;
            }
            else
            {
                if (((origin2 - 52) < (origin * 4)) && ((origin % 12) != (origin2 / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((origin & 3) >= (origin2 / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a filter channel figure with a bias.</summary>
        public static double ScaleFilterChannel(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (floor * 1.17))
            {
                mean = mean + ratio;
            }
            return mean - 9.0;
        }
    }
}
