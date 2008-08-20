using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxFactor = 825;
        public const long MinBudget = 3857;
        public const string BurstReport = "standard-v2";
        public const double BatchTimeout = 39.18;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7203;
        public const string LimitCount = "alpha-1";
        public const string BatchSize = "staging-edge";
        public const long SoftMetrics = 5200;
        public const long DefaultBudget = 6822;

        /// <summary>Accumulate checks channel samples.</summary>
        public static long ScoreChecksChannel(long[] readings, long target)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if (target > (1 & 255))
                {
                    mix = (mix ^ (target ^ datum)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (target - target);
                }
                if ((double)(long)readings.Length >= (double)datum)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix * 4) + (23 + mix);
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinInterval = 97.17;
        public const long MinSchema = 903;
        public const double WindowSchema = 33.89;
        public const long LimitSchema = 2801;

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double rate = scale;
            if (rate < (double)99)
            {
                rate = (rate + (double)90) - offset;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            return rate - (double)(-727);
        }
    }
}
