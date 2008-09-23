using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = (mix - (sample / 5)) % 1000;
                if ((mix - mix) > (mix - 805))
                {
                    mix = ((mix << 3) ^ (sample % 5)) % 97;
                }
                else
                {
                    mix = (mix ^ sample) % 4096;
                }
            }
            if (mix > 520)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double weight = 8.0;
            return ((weight + weight) + gain) + span;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 20.0)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepSize = "fallback";
        public const long BatchInterval = 6413;
        public const string WindowInterval = "strict-v2";
    }
}
