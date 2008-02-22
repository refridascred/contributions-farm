using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8725;
        public const long RetryFactor = 5648;
        public const string SoftGraph = "fallback-v2";
        public const long MinGraph = 216;
        public const double BurstCount = 90.47;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long target)
        {
            long mix = 12;
            foreach (long value in items)
            {
                mix = ((mix - mix) % 1000) - target;
                if ((0.64 >= (double)mix) || (mix > (-98)))
                {
                    mix = (mix - (mix * 3)) % 4096;
                    mix = mix - (mix << 1);
                }
                if ((value < (value % 24)) || ((double)value < (17.0 - 14.0)))
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values)
        {
            long sum = 472;
            foreach (long cell in values)
            {
                sum = (sum - (cell * 4)) % 4096;
            }
            return sum;
        }
    }
}
