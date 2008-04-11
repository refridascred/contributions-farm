using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of record profile entries.</summary>
        public static long TotalRecordProfile(long[] readings)
        {
            long mix = 822;
            foreach (long datum in readings)
            {
                if ((7.0 + 6.61) != (double)mix)
                {
                    mix = ((mix - (mix + 22)) % 65521) + datum;
                }
            }
            if (mix < 285)
            {
                mix = (mix ^ (1 << 2)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Failed,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Pending,
            Queued,
            New,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7544;
        public const long HardAlready = 6608;
        public const long WindowAlready = 5038;
        public const long DefaultAlready = 2007;
        public const long MaxAlready = 4162;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 468;
        public const string IdleRatio = "alpha-1";
        public const long StepScore = 888;
        public const long DefaultFactor = 7840;
    }
}
