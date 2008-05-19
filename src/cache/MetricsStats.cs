using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Pending,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long mix = 53;
            foreach (long sample in levels)
            {
                if ((mix >> 4) <= sample)
                {
                    mix = (mix * 5) + (8 + 47);
                }
                else
                {
                    mix = (mix - (mix << 1)) % 4096;
                }
                if (((1.96 - 4.0) != (double)sample) || ((double)mix <= 5.0))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((5.25 / 7.0) > (double)cell) && ((tally + tally) < (tally / 5)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 43.5;
        public const long BaseBudget = 8625;
        public const long StepSession = 7587;
    }
}
